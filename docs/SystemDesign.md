# System Design Document (SDD)

## 1. Architecture Overview
The E-Commerce Admin Dashboard follows a standard modern SPA (Single Page Application) with a RESTful backend architecture, utilizing clean separation of concerns and containerized deployment.

## 2. Technology Stack
- **Frontend:** React / Next.js (TypeScript) or Angular 18 (TypeScript) with Tailwind CSS / Material UI for robust UI components.
- **Backend:** ASP.NET Core 8 Web API, C#.
- **Database:** PostgreSQL or Microsoft SQL Server (Containerized).
- **ORM:** Entity Framework Core (Code-First Approach).
- **Authentication:** ASP.NET Core Identity with JWT (JSON Web Tokens).
- **Infrastructure:** Docker and Docker Compose for local environments; GitHub Actions for CI/CD.

## 3. Core Architecture Design

### 3.1. High-Level Component Interaction
```text
[ Web Browser (React/Angular SPA) ] 
      |
      | HTTP (REST API calls over HTTPS) + JWT token in Authorization Header
      V
[ API Gateway / Load Balancer (Nginx or Cloud provider) ]
      |
      V
[ ASP.NET Core Web API ]
      |-- Controllers (Auth, Users, Products, Orders)
      |-- Services (Business Logic layer)
      |-- Repositories (Data Access layer - EF Core)
      |
      V
[ Relational Database (SQL Server / PostgreSQL) ]
```

### 3.2. Database Schema (Initial)

**Users:**
- `Id` (GUID, PK)
- `Email` (String, Unique)
- `PasswordHash` (String)
- `IsActive` (Boolean)
- `LastLogin` (DateTime)

**Roles:**
- `Id` (GUID, PK)
- `Name` (String, Unique) -> e.g., 'SuperAdmin', 'Admin', 'Manager', 'Viewer'

**UserRoles (Mapping Table):**
- `UserId` (FK to Users)
- `RoleId` (FK to Roles)

**AuditLogs:**
- `Id` (GUID, PK)
- `Action` (String) -> e.g., 'UserRoleAssigned'
- `PerformedByUserId` (FK to Users)
- `TargetId` (String, nullable)
- `Timestamp` (DateTimeOffset)

### 3.3. API Contracts (Initial)

*   `POST /api/auth/login` (Body: `{ email, password }` | Response: `{ token, refreshToken, user: { id, email, roles[] } }`)
*   `GET /api/users` (Requires: `[Authorize(Roles="SuperAdmin")]` | Response: List of Users)
*   `PUT /api/users/{id}/roles` (Requires: `[Authorize(Roles="SuperAdmin")]` | Body: `[roleIds]`)
*   `GET /api/dashboard/stats` (Requires: `[Authorize]` | Response: `{ totalSales, activeOrders, newUsers }`)

## 4. Enterprise Standards Compliance
- **Dependency Injection:** Strict adherence to .NET's built-in DI container to ensure decoupled, testable services.
- **Error Handling:** Centralized Global Exception Middleware returning standardized `ProblemDetails` JSON responses (RFC 7807).
- **Rate Limiting:** IP-based rate limiting on `/api/auth` endpoints to mitigate brute force attacks.
- **Logging:** Structured logging using Serilog (sinking to Console and a centralized log management system like Elasticsearch or Seq).
- **CORS:** Strictly configured CORS policies restricting API access to the approved frontend domain.
- **Database Migrations:** Managed solely via EF Core Migrations deployed incrementally in CI/CD pipelines.
