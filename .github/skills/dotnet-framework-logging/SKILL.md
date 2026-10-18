---
name: dotnet-framework-logging
description: Integrate Azure Application Insights logging in a legacy .NET Framework 4.x ASP.NET MVC / Web API project hosted on IIS.
---

# Integrating Application Insights in .NET Framework 4.x Projects

Follow these instructions to configure Azure Application Insights telemetry and logging in an ASP.NET MVC or Web API project targeting .NET Framework 4.x, hosted on IIS.

> [!NOTE]
> This skill covers the **legacy SDK approach** (`Microsoft.ApplicationInsights.Web`). For modern .NET (6+) projects, use the `dotnet-logging` skill which uses the OpenTelemetry-based distro instead.

## Step 1: Install the NuGet Package

The `Microsoft.ApplicationInsights.Web` meta-package automatically pulls in:
- `Microsoft.ApplicationInsights` (core SDK)
- `Microsoft.ApplicationInsights.DependencyCollector` (SQL, HTTP dependency tracking)
- `Microsoft.ApplicationInsights.PerfCounterCollector` (CPU, memory, Live Metrics)
- `Microsoft.ApplicationInsights.WindowsServer` (server-level telemetry)
- `Microsoft.AspNet.TelemetryCorrelation` (distributed tracing correlation)

```powershell
Install-Package Microsoft.ApplicationInsights.Web
```

## Step 2: Configure ApplicationInsights.config

This file is created automatically in the project root after installing the NuGet package. Set the **Connection String** (do not use the deprecated `InstrumentationKey`):

```xml
<?xml version="1.0" encoding="utf-8"?>
<ApplicationInsights xmlns="http://schemas.microsoft.com/ApplicationInsights/2013/Settings">

  <ConnectionString>YOUR_CONNECTION_STRING_HERE</ConnectionString>

  <!-- Telemetry Initializers -->
  <TelemetryInitializers>
    <Add Type="Microsoft.ApplicationInsights.DependencyCollector.HttpDependenciesParsingTelemetryInitializer, Microsoft.AI.DependencyCollector"/>
    <Add Type="Microsoft.ApplicationInsights.WindowsServer.AzureRoleEnvironmentTelemetryInitializer, Microsoft.AI.WindowsServer"/>
    <Add Type="Microsoft.ApplicationInsights.Web.OperationNameTelemetryInitializer, Microsoft.AI.Web"/>
    <Add Type="Microsoft.ApplicationInsights.Web.OperationCorrelationTelemetryInitializer, Microsoft.AI.Web"/>
    <Add Type="Microsoft.ApplicationInsights.Web.UserTelemetryInitializer, Microsoft.AI.Web"/>
    <Add Type="Microsoft.ApplicationInsights.Web.SessionTelemetryInitializer, Microsoft.AI.Web"/>
  </TelemetryInitializers>

  <!-- Telemetry Modules -->
  <TelemetryModules>
    <Add Type="Microsoft.ApplicationInsights.Web.RequestTrackingTelemetryModule, Microsoft.AI.Web"/>
    <Add Type="Microsoft.ApplicationInsights.Web.ExceptionTrackingTelemetryModule, Microsoft.AI.Web"/>
    <Add Type="Microsoft.ApplicationInsights.DependencyCollector.DependencyTrackingTelemetryModule, Microsoft.AI.DependencyCollector">
      <EnableSqlCommandTextInstrumentation>true</EnableSqlCommandTextInstrumentation>
    </Add>
    <Add Type="Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.PerformanceCollectorModule, Microsoft.AI.PerfCounterCollector"/>
    <Add Type="Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse.QuickPulseTelemetryModule, Microsoft.AI.PerfCounterCollector"/>
  </TelemetryModules>

  <!-- Adaptive Sampling -->
  <TelemetryProcessors>
    <Add Type="Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse.QuickPulseTelemetryProcessor, Microsoft.AI.PerfCounterCollector"/>
    <Add Type="Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel.AdaptiveSamplingTelemetryProcessor, Microsoft.AI.ServerTelemetryChannel">
      <MaxTelemetryItemsPerSecond>5</MaxTelemetryItemsPerSecond>
      <ExcludedTypes>Event</ExcludedTypes>
    </Add>
  </TelemetryProcessors>

  <TelemetryChannel Type="Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel.ServerTelemetryChannel, Microsoft.AI.ServerTelemetryChannel"/>
</ApplicationInsights>
```

> [!TIP]
> In production, set the `APPLICATIONINSIGHTS_CONNECTION_STRING` environment variable or use Azure Key Vault. Avoid committing real connection strings to source control.

## Step 3: Register HTTP Modules in Web.config

Both Classic and Integrated IIS pipeline modes require module registration:

```xml
<configuration>
  <!-- IIS Classic Pipeline Mode -->
  <system.web>
    <httpModules>
      <add name="TelemetryCorrelationHttpModule"
           type="Microsoft.AspNet.TelemetryCorrelation.TelemetryCorrelationHttpModule, Microsoft.AspNet.TelemetryCorrelation"/>
      <add name="ApplicationInsightsWebTracking"
           type="Microsoft.ApplicationInsights.Web.ApplicationInsightsHttpModule, Microsoft.AI.Web"/>
    </httpModules>
  </system.web>

  <!-- IIS Integrated Pipeline Mode (most common) -->
  <system.webServer>
    <modules>
      <remove name="TelemetryCorrelationHttpModule"/>
      <add name="TelemetryCorrelationHttpModule"
           type="Microsoft.AspNet.TelemetryCorrelation.TelemetryCorrelationHttpModule, Microsoft.AspNet.TelemetryCorrelation"
           preCondition="managedHandler"/>
      <remove name="ApplicationInsightsWebTracking"/>
      <add name="ApplicationInsightsWebTracking"
           type="Microsoft.ApplicationInsights.Web.ApplicationInsightsHttpModule, Microsoft.AI.Web"
           preCondition="managedHandler"/>
    </modules>
    <validation validateIntegratedModeConfiguration="false"/>
  </system.webServer>
</configuration>
```

> [!TIP]
> The `<remove>` before `<add>` pattern prevents duplicate module registration errors.

## Step 4: Global.asax.cs Initialization

```csharp
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

public class MvcApplication : HttpApplication
{
    protected void Application_Start()
    {
        AreaRegistration.RegisterAllAreas();
        GlobalConfiguration.Configure(WebApiConfig.Register);
        RouteConfig.RegisterRoutes(RouteTable.Routes);

        // Optional: Set connection string from AppSettings
        string connStr = System.Configuration.ConfigurationManager
            .AppSettings["APPINSIGHTS_CONNECTION_STRING"];
        if (!string.IsNullOrEmpty(connStr))
        {
            TelemetryConfiguration.Active.ConnectionString = connStr;
        }
    }

    protected void Application_End()
    {
        // CRITICAL: Flush buffered telemetry before app pool shutdown
        var telemetryClient = new TelemetryClient();
        telemetryClient.Flush();
        System.Threading.Thread.Sleep(5000); // Wait for async upload
    }
}
```

> [!IMPORTANT]
> The `Application_End()` flush with `Thread.Sleep(5000)` is essential to prevent telemetry loss during IIS app pool recycles. Never call `Flush()` per-request — it causes thread pool starvation.

## Step 5: Using TelemetryClient in Controllers

`TelemetryClient` is thread-safe and automatically reads config from `TelemetryConfiguration.Active`.

### MVC Controller Example
```csharp
using Microsoft.ApplicationInsights;
using System.Collections.Generic;
using System.Web.Mvc;

public class OrdersController : Controller
{
    private readonly TelemetryClient _telemetryClient = new TelemetryClient();

    public ActionResult Index()
    {
        _telemetryClient.TrackEvent("OrdersPageViewed");
        return View();
    }

    public ActionResult Checkout(string orderId)
    {
        _telemetryClient.TrackEvent("CheckoutStarted",
            new Dictionary<string, string> { { "OrderId", orderId } },
            new Dictionary<string, double> { { "CartItemCount", 5 } });

        return View();
    }
}
```

### Web API Controller Example
```csharp
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using System.Web.Http;

public class ProductsController : ApiController
{
    private static readonly TelemetryClient _telemetryClient = new TelemetryClient();

    [HttpGet]
    public IHttpActionResult Get(int id)
    {
        _telemetryClient.TrackTrace($"Product {id} requested", SeverityLevel.Information);
        return Ok(new { Id = id, Name = "Widget" });
    }
}
```

### Available TelemetryClient Methods

| Method | Purpose |
|:---|:---|
| `TrackEvent()` | Custom business events (orders placed, buttons clicked) |
| `TrackMetric()` | Numeric measurements (queue depth, cart value) |
| `TrackException()` | Exceptions with optional custom properties |
| `TrackTrace()` | Diagnostic log messages with severity level |
| `TrackDependency()` | External dependency calls (APIs, databases) |
| `TrackRequest()` | Custom request tracking |

## Step 6: Logging Framework Integration

### log4net → Application Insights

```powershell
Install-Package Microsoft.ApplicationInsights.Log4NetAppender
```

```xml
<log4net>
  <appender name="aiAppender"
            type="Microsoft.ApplicationInsights.Log4NetAppender.ApplicationInsightsAppender, Microsoft.ApplicationInsights.Log4NetAppender">
    <layout type="log4net.Layout.PatternLayout">
      <conversionPattern value="%message%newline" />
    </layout>
  </appender>
  <root>
    <level value="INFO" />
    <appender-ref ref="aiAppender" />
  </root>
</log4net>
```

### NLog → Application Insights

```powershell
Install-Package Microsoft.ApplicationInsights.NLogTarget
```

```xml
<nlog>
  <extensions>
    <add assembly="Microsoft.ApplicationInsights.NLogTarget" />
  </extensions>
  <targets>
    <target name="aiTarget" xsi:type="ApplicationInsightsTarget" />
  </targets>
  <rules>
    <logger name="*" minlevel="Info" writeTo="aiTarget" />
  </rules>
</nlog>
```

### System.Diagnostics.Trace → Application Insights

```powershell
Install-Package Microsoft.ApplicationInsights.TraceListener
```

```xml
<system.diagnostics>
  <trace autoflush="true" indentsize="0">
    <listeners>
      <add name="myAppInsightsListener"
           type="Microsoft.ApplicationInsights.TraceListener.ApplicationInsightsTraceListener, Microsoft.ApplicationInsights.TraceListener"/>
    </listeners>
  </trace>
</system.diagnostics>
```

> [!NOTE]
> All logging adapters automatically pick up the connection string from `ApplicationInsights.config`. No additional key configuration is needed in the logging config.

## Step 7: IIS Best Practices

1. **Connection String over InstrumentationKey**: Always use `<ConnectionString>` for regional endpoint routing and forward compatibility.
2. **Adaptive Sampling**: Enabled by default. Tune `MaxTelemetryItemsPerSecond` in `ApplicationInsights.config` to control ingestion costs.
3. **IIS App Pool Settings**: Set `preloadEnabled="true"` and `startMode="AlwaysRunning"` to avoid cold starts.
4. **Deploy `ApplicationInsights.config`**: Ensure it is in the application root with `Build Action = Content` and `Copy to Output Directory = Copy always`.
5. **Application Insights Agent**: For on-premises IIS servers, consider the Application Insights Agent for codeless instrumentation and deeper profiling.
6. **Log Level Tuning**: In production, set logging levels to `Warning` or `Error` for high-volume namespaces.
7. **Validate with Live Metrics**: After deployment, use the Live Metrics Stream in Azure Portal to verify telemetry is flowing.
