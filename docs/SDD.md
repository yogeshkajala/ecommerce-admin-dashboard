# System Design Document (SDD)
**Project Name:** E-Commerce Admin Dashboard
**Version:** 1.0.0
**Date:** March 2026

---

## 1. Introduction
### 1.1 Purpose
This System Design Document (SDD) outlines the architectural, structural, and behavioral design of the E-Commerce Admin Dashboard. It serves as the primary technical reference for developers, architects, and stakeholders to ensure alignment with enterprise-grade standards.

### 1.2 Scope
The system is a centralized administrative interface for managing an e-commerce platform. It handles user management (SuperAdmin), inventory, order processing, and analytics. The solution leverages a modern tech stack: **.NET 8 (C#)** for the backend, **Angular 17+** for the frontend, and **SQL Server** for persistence, running entirely within **Docker** containers for seamless deployment.

---

## 2. Architectural Overview
### 2.1 High-Level Architecture
The system follows a **Client-Server Architecture** utilizing a **RESTful Web API** backend and a **Single Page Application (SPA)** frontend.

### 2.2 Design Pattern: Clean Architecture
The backend rigorously adheres to Clean Architecture (Onion Architecture) principles, ensuring separation of concerns, testability, and framework independence. 

*   **Core (Domain Layer):** Contains enterprise logic, entities (e.g., `SuperAdmin`), enums, and domain interfaces. Has *zero* external dependencies.
*   **Application (Use Case Layer):** Contains business logic, DTOs, CQRS handlers, and abstractions (interfaces for repositories). References *Core*.
*   **Infrastructure (Data & External Layer):** Implements Core/Application interfaces. Contains Entity Framework Core DbContext, ASP.NET Core Identity stores, external API integrations, and database migrations. References *Application* and *Core*.
*   **API (Presentation Layer):** The entry point. Controllers/Minimal APIs, middleware, routing, and Dependency Injection setup. References *Application* and *Infrastructure*.

---

## 3. System Components
### 3.1 Frontend (Client)
*   **Framework:** Angular (Standalone Components, strict mode).
*   **Routing:** Angular Router with lazy loading for feature modules (e.g., Inventory, Users, Settings).
*   **State Management:** Signals or NgRx (depending on complexity).
*   **Styling:** SCSS, with an enterprise UI library (e.g., Angular Material or Tailwind CSS).

### 3.2 Backend (Server)
*   **Framework:** .NET 8 Web API.
*   **Authentication:** JWT (JSON Web Tokens) integrated with ASP.NET Core Identity.
*   **ORM:** Entity Framework (EF) Core.
*   **Validation:** FluentValidation.
*   **Mapping:** AutoMapper or Mapster.

---

## 4. Data Design
### 4.1 Database Engine
*   **System:** Microsoft SQL Server 2022 (containerized via Docker).
*   **Access Paradigm:** Code-First Migrations via EF Core.

### 4.2 Core Entities (Initial Schema)
*   **`SuperAdmin`:** Inherits from `IdentityUser`. Attributes: `FirstName`, `LastName`, `CreatedAt`, `IsActive`.

*(Note: Schema will expand with `Products`, `Orders`, `Customers`, etc., as feature modules are developed.)*

---

## 5. Security & Authentication
### 5.1 Identity Management
*   **ASP.NET Core Identity:** Handles hashing, salting, and secure storage of user credentials.
*   **Role-Based Access Control (RBAC):** Users are assigned roles (e.g., `SuperAdmin`, `Manager`, `Viewer`) determining API endpoint accessibility via `[Authorize(Roles="...")]`.

### 5.2 API Security
*   **JWT Bearer Authentication:** Stateless tokens signed with a secure, injected private key.
*   **CORS Policies:** Strictly defined to allow requests only from the deployed Angular client domains.
*   **Rate Limiting & Throttling:** Built-in .NET rate limiting to prevent DDoS or brute-force attacks.

---

## 6. Infrastructure & Deployment
### 6.1 Containerization
*   **Docker Compose:** Orchestrates the multi-container environment.
    *   `db`: `mcr.microsoft.com/mssql/server:2022-latest`
    *   `api`: .NET 8 runtime container.
    *   `client`: NGINX container serving the compiled Angular static assets.

### 6.2 CI/CD Pipeline (Proposed)
*   **Version Control:** GitHub (feature-branch workflow with PR reviews).
*   **Continuous Integration:** GitHub Actions to build the .NET solution, run unit tests, and lint the Angular code on every PR.
*   **Continuous Deployment:** Automated Docker image builds pushed to a container registry (e.g., GHCR, Docker Hub) upon merge to `main`.

---

## 7. Non-Functional Requirements (NFRs)
*   **Scalability:** Stateless API design allows horizontal scaling behind a load balancer.
*   **Maintainability:** Strict Clean Architecture boundaries prevent "spaghetti code."
*   **Performance:** EF Core queries optimized with `AsNoTracking()` for read-only operations. Database indexed appropriately.
*   **Observability:** Structured logging (e.g., Serilog) implemented across the API, capturing system events, errors, and access logs.
