# Business Requirements Document (BRD) - Dashboard App

## 1. Overview
This document defines the basic building blocks and Acceptance Criteria (AC) for the Dashboard Application. The focus is on simplicity to quickly establish a working baseline.

## 2. Basic Blocks

### 2.1. Authentication & Role Management
**Description:** Secure the application and manage user permissions.
**Acceptance Criteria:**
- System supports dynamic authentication connectors (e.g., Entra, OIDC).
- System supports Role-based Access Control (RBAC).
- "Admin" role exists and is required for destructive operations.

### 2.2. Product Catalog Management
**Description:** Full lifecycle management of products.
**Acceptance Criteria:**
- Authorized users can Create, Read, and Update (CRU) products.
- Only users with the "Admin" or designated role can Delete products.
- Product fields include: Id, Name, Description, SKU, Price, StockQuantity, CreatedAt, UpdatedAt.

### 2.3. eShop Platform Integration (New)
**Description:** Connect the Admin Dashboard into the core eShop microservices ecosystem.
**Acceptance Criteria:**
- The Dashboard seamlessly connects to the `eShop` PostgreSQL `CatalogDB` and SQL Server `IdentityDB`.
- The Dashboard participates in the `eShop.AppHost` (.NET Aspire) orchestration for centralized service discovery and telemetry.
- The Dashboard can publish/subscribe to the `EventBusRabbitMQ` to listen for order status updates and broadcast catalog changes.

---
*Note: Ad-hoc tasks outside these core blocks are managed separately on the Kanban board (`tasks.md`).*