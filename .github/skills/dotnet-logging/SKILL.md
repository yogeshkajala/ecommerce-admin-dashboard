---
name: dotnet-logging
description: Integrate OpenTelemetry-based observability with Azure Monitor in a .NET Core / modern .NET API project.
---

# Integrating OpenTelemetry + Azure Monitor in .NET Core Projects

Follow these instructions to configure OpenTelemetry-based tracing, metrics, and logging with Azure Application Insights as the export backend in a modern .NET (6+) ASP.NET Core project.

> [!NOTE]
> This skill uses the **Azure Monitor OpenTelemetry Distro** (`Azure.Monitor.OpenTelemetry.AspNetCore`), which is Microsoft's recommended approach for new projects. It replaces the legacy `Microsoft.ApplicationInsights.AspNetCore` SDK. **Do not mix** the two in the same project.

## Step 1: Install the Azure Monitor Distro Package

The distro is an all-in-one package that bundles:
- OpenTelemetry core SDK
- ASP.NET Core instrumentation (traces + metrics)
- HttpClient instrumentation (traces + metrics)
- SqlClient instrumentation
- Azure Monitor exporter

```bash
dotnet add package Azure.Monitor.OpenTelemetry.AspNetCore
```

If migrating from the legacy SDK, remove the old package first:

```bash
dotnet remove package Microsoft.ApplicationInsights.AspNetCore
```

## Step 2: (Optional) Install Runtime Instrumentation

For GC, ThreadPool, and process-level metrics:

```bash
dotnet add package OpenTelemetry.Instrumentation.Runtime
```

## Step 3: Register OpenTelemetry in Program.cs

Add the following using directive and service registration:

```csharp
using Azure.Monitor.OpenTelemetry.AspNetCore;
using OpenTelemetry.Metrics;

var builder = WebApplication.CreateBuilder(args);

var otelBuilder = builder.Services.AddOpenTelemetry();

// Only enable Azure Monitor export when a real connection string is configured.
// This allows the app to start locally without a valid Azure connection string.
var azureMonitorConnectionString = builder.Configuration["AzureMonitor:ConnectionString"];
if (!string.IsNullOrEmpty(azureMonitorConnectionString)
    && !azureMonitorConnectionString.StartsWith("YOUR_"))
{
    otelBuilder.UseAzureMonitor(options =>
    {
        options.ConnectionString = azureMonitorConnectionString;
    });
}

otelBuilder
    .WithTracing(tracing =>
    {
        // Register custom ActivitySources for manual tracing
        tracing.AddSource("YourAppName");
    })
    .WithMetrics(metrics =>
    {
        // Register custom Meters for manual metrics
        metrics.AddMeter("YourAppName");

        // Add runtime metrics (GC, ThreadPool, etc.)
        metrics.AddRuntimeInstrumentation();
    });
```

> [!TIP]
> `UseAzureMonitor()` automatically adds ASP.NET Core, HttpClient, and SqlClient instrumentation. You do **not** need to add those manually.

## Step 4: Configure Connection String

In `appsettings.json`:

```json
{
  "AzureMonitor": {
    "ConnectionString": "YOUR_CONNECTION_STRING_HERE"
  }
}
```

> [!TIP]
> In production, use the environment variable `APPLICATIONINSIGHTS_CONNECTION_STRING` or Azure Key Vault instead of hardcoding the connection string.

## Step 5: Enable OpenTelemetry Logging

Wire `ILogger` output into the OpenTelemetry pipeline so logs are correlated with traces:

```csharp
builder.Logging.AddOpenTelemetry(logging =>
{
    logging.IncludeFormattedMessage = true;
    logging.IncludeScopes = true;
});
```

This replaces the legacy `"Logging" > "ApplicationInsights"` log-level filter section. Standard `"Logging" > "LogLevel"` rules apply.

## Step 6: Implement Structured Logging

Always use structured logging templates (not string interpolation) so that properties are correctly parsed and queryable in Azure Portal / Log Analytics.

### Minimal APIs Example
```csharp
app.MapGet("/items", (ILogger<Program> logger) =>
{
    logger.LogInformation("Retrieving items requested at {Time}", DateTime.UtcNow);
    return Results.Ok();
});
```

### Controller-based API Example
```csharp
public class ItemsController : ControllerBase
{
    private readonly ILogger<ItemsController> _logger;

    public ItemsController(ILogger<ItemsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Retrieving items via controller");
        return Ok();
    }
}
```

## Step 7: Verification & Best Practices

1. **Verify Build**: Run `dotnet build` to ensure all packages restore and compile correctly.
2. **Setup Gitignore**: Ensure build directories (`bin/`, `obj/`) are ignored (`dotnet new gitignore`).
3. **Log Levels**: Keep logging levels set to `Warning` or `Error` for high-volume namespaces in production to optimize ingestion costs.
4. **Custom Telemetry**: Use `System.Diagnostics.Activity` and `System.Diagnostics.Metrics` (standard .NET APIs) instead of the legacy `TelemetryClient`.
5. **Multi-Backend**: OpenTelemetry supports exporting to multiple backends simultaneously (Azure + Jaeger + Prometheus + any OTLP endpoint).
