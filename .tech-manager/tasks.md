# Task List (Kanban + Scrum)

## In Discussion
- [ ] **Infrastructure:** Plan the switch of our local `CatalogDbContext` to point directly to the Aspire-managed `CatalogDB` Postgres container.
- [ ] **Messaging:** Design the `EventBusRabbitMQ` subscriber for the Admin Dashboard to receive real-time updates from `Ordering.API`.

## To Do
- [ ] **AI Manager Persistence:** Initialize a new repository (`ai-tech-manager-core`), migrate the `.tech-manager` configuration, and set up a SQLite database to persistently track tasks, roles, and variables. (Assigned to: Backend-Dev-Agent)

## In Progress
*(Empty)*

## Done
- [x] **Research:** Collect information and create a comprehensive Project Plan regarding UP government subsidies for solar, irrigation, and farming. (Research-Agent)
- [x] **Architecture:** Restructure repository folders to match eShop's style. (Backend-Dev-Agent)
- [x] **Data Model Alignment:** Refactor the `Product` entity to exactly match eShop's `CatalogItem` schema. (Backend-Dev-Agent)
- [x] **Documentation:** Setup the initial BRD structure. (Created `BRD.md`)
- [x] **Process:** Define how the AI Technical Manager will independently manage the VPS environment. *(Documented in `AUTHORITY.md`)*
- [x] **Process:** Finalize strict Branching Strategy & PR rules. *(Updated `skills/branching-strategy/SKILL.md`)*
- [x] **Architecture:** Design abstraction layer for connectors (`IAuthenticationConnector`).
- [x] **Implementation:** Configure Entra (Azure AD) as the initial connector. (Phase 2).
- [x] **Core API:** Build out specific models using the configured databases. (Backend-Dev-Agent)
- [x] **Implementation:** Alternative Auth Connector (OIDC) using the abstraction pattern. (Auth-Integration-Agent)
- [x] **Testing:** Robust Unit Tests for the Database connections. (QA-Test-Agent)

## Backlog
*(Empty)*