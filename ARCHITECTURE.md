# ARCHITECTURE.md - Clean Architecture & Design Patterns

This document defines the strict architectural boundaries for the `ecommerce-admin-dashboard` project. **All agents must strictly adhere to these rules.**

## 1. Clean Architecture Layers
The project is strictly divided into four layers, and dependencies must only flow inwards (towards Core).

1. **Core (`EcommerceAdmin.Core`)**
   - Contains Entities, Enums, Exceptions, and Interfaces.
   - **Rule:** Must NEVER reference any other project layer or external infrastructure libraries (e.g., Entity Framework, Npgsql).

2. **Application (`EcommerceAdmin.Application`)**
   - Contains Business Logic, Services (e.g., `ProductService`), and DTOs.
   - **Rule:** Must reference ONLY the `Core` project. 
   - **Rule:** Must NEVER reference the `Infrastructure` project or know about the database context.

3. **Infrastructure (`EcommerceAdmin.Infrastructure`)**
   - Contains Database Contexts (`CatalogDbContext`, `ApplicationDbContext`), Repositories, and External Service integrations (e.g., Auth, Caching).
   - **Rule:** References both `Core` and `Application` (to implement their interfaces).
   - **Rule:** All database operations MUST be abstracted behind the **Repository Pattern**. Services in the Application layer must not inject `DbContext` directly.

4. **API / Presentation (`EcommerceAdmin.API`)**
   - Contains Controllers, Program.cs, and Dependency Injection setup.
   - **Rule:** Controllers must inject Application Services (e.g., `IProductService`), NEVER Repositories or DbContexts directly.

## 2. eShop Integration Strategy
- **Database Models (Bounded Contexts):** We do NOT share a common Models DLL. The Dashboard maintains its own representation of entities (e.g., `CatalogItem`) that map to the shared database tables. This prevents tight domain coupling.
- **Service Configuration:** The Dashboard will utilize `eShop.ServiceDefaults` for Aspire orchestration, OpenTelemetry, and HealthChecks.
- **Messaging Contracts:** Integration Events (RabbitMQ) will use shared contracts/DTOs to ensure payload consistency.

## 3. Enforcement
- Any PR that violates these dependency arrows or bypasses the Repository Pattern will be rejected.
- Controllers deal with HTTP; Services deal with Business Rules; Repositories deal with Data. Keep them separated.