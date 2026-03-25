# SYSTEM DESIGN DOCUMENT (SDD) - Pluggable Admin Dashboard

## 1. Architectural Vision
The `ecommerce-admin-dashboard` is designed as a standalone, pluggable vertical slice. It must be able to integrate seamlessly into a larger microservices ecosystem (e.g., the official .NET `eShop` reference app) while maintaining zero hard code dependencies on the host ecosystem's proprietary libraries or shared domain DLLs.

## 2. Integration Strategy: The Pluggable Module

### 2.1 Host Integration via Git Submodules
- **Pattern:** The Dashboard repository will be integrated into the host ecosystem (e.g., eShop) as a Git Submodule.
- **Orchestration:** The host's orchestration layer (e.g., `.NET Aspire` `AppHost`) will reference the Dashboard's `.csproj` file and inject necessary environment variables (Database Connection Strings, RabbitMQ endpoints) at runtime.
- **Benefit:** The Dashboard remains 100% decoupled from the host repository's lifecycle and source control, allowing independent development and testing.

### 2.2 Database Bounded Contexts
- **Pattern:** The Dashboard maps directly to the host's physical database tables (e.g., PostgreSQL `CatalogDB`) using Entity Framework Core, but it maintains its *own* separate Entity definitions (e.g., `CatalogItem`).
- **Benefit:** This prevents tight domain coupling. The Dashboard ignores host-specific fields it does not require.
- **Testing:** Integration tests within the Dashboard repository will utilize **Testcontainers** (or EF InMemory) to spin up isolated, ephemeral databases. It will never require the host's live database for CI/CD testing.

### 2.3 Agnostic Observability
- **Pattern:** The Dashboard will NOT consume host-specific configuration libraries (e.g., `eShop.ServiceDefaults`).
- **Implementation:** It will implement standard OpenTelemetry and ASP.NET Core Health Checks. 
- **Benefit:** The host orchestrator can simply pass standard OTLP environment variables (`OTEL_EXPORTER_OTLP_ENDPOINT`) to wire the Dashboard into the ecosystem's centralized telemetry (e.g., Aspire Dashboard or Datadog) without proprietary code dependencies.

### 2.4 Messaging: The Tolerant Reader Pattern
- **Pattern:** The Dashboard will NOT reference shared contract libraries (`.dll` or NuGet) from the host for RabbitMQ/EventBus messaging.
- **Implementation:** It will employ the **Tolerant Reader Pattern**. The Dashboard defines its own lightweight C# `record` definitions for incoming JSON payloads, mapping only the fields it cares about (e.g., `OrderId`, `TotalAmount`).
- **Benefit:** If the host ecosystem adds or modifies unrelated fields in an integration event, the Dashboard's deserialization will not break.
