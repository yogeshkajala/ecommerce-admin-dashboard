# Task List (Kanban + Scrum)

## In Discussion
- [ ] **Infrastructure:** Plan the switch of our local `CatalogDbContext` to point directly to the Aspire-managed `CatalogDB` Postgres container.
- [ ] **Messaging:** Design the `EventBusRabbitMQ` subscriber for the Admin Dashboard to receive real-time updates from `Ordering.API`.

## To Do
*(Empty)*

## In Progress
*(Empty)*

## Done
- [x] **Architecture:** Restructure repository folders to match eShop's style: move application projects to a `src/` directory and test projects to a `tests/` directory. Rename `EcommerceAdmin.Api` to `EcommerceAdmin.API`. (Backend-Dev-Agent)
- [x] **Data Model Alignment:** Refactor the `Product` entity in our Domain to exactly match eShop's `CatalogItem` schema (change `Id` from `Guid` to `int`, match `AvailableStock`, `CatalogBrandId`, etc.) so it maps perfectly to the existing `CatalogDB`. Update all Repositories, Services, and Controllers to reflect this change. (Backend-Dev-Agent)
- [x] **Documentation:** Setup the initial BRD (Business Requirements Document) structure to define the basic blocks and Acceptance Criteria for the "Dashboard app". (Created `BRD.md`)
- [x] **Process:** Define how Kana will independently manage the VPS environment (e.g., SDKs, scaffolding, migrations) to eliminate blockers when Yogesh is unavailable. *(Documented in `AUTHORITY.md`)*
- [x] **Process:** Finalize strict Branching Strategy & PR rules (no rogue commits to main, one feature branch per task). *(Updated `skills/branching-strategy/SKILL.md`)*
- [x] **Architecture:** Design abstraction layer for connectors (`IAuthenticationConnector`).
- [x] **Implementation:** Configure Entra (Azure AD) as the initial connector using the abstraction layer (Phase 2).
- [x] **Core API:** Build out specific models using the configured databases. (Backend-Dev-Agent)
- [x] **Implementation:** Alternative Auth Connector (OIDC) using the abstraction pattern. (Auth-Integration-Agent)
- [x] **Testing:** Robust Unit Tests for the Database connections. (QA-Test-Agent)

## Backlog
*(Empty)*