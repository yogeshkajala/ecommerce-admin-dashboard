# Business Requirements Document (BRD)

## 1. Executive Summary
The E-Commerce Admin Dashboard is a centralized portal for managing an online storefront's operations, including users, roles, products, orders, and high-level analytics. It provides secure, role-based access to sensitive business data.

## 2. Scope
This phase covers:
- Secure authentication via JWT.
- Role-Based Access Control (RBAC) with `SuperAdmin`, `Admin`, `Manager`, and `Viewer` roles.
- SuperAdmin User Management module.
- High-level Dashboard overview.

## 3. User Stories (Focus: SuperAdmin Dashboard & User Management)

### US-01: SuperAdmin User Management
**As a** SuperAdmin,
**I want to** view, add, edit, and deactivate system users, and assign them specific roles,
**So that** I can securely manage staff access to the e-commerce backend.

**Acceptance Criteria:**
- The SuperAdmin sees a data table listing all users (Name, Email, Assigned Roles, Status, Last Login).
- The SuperAdmin can click "Invite User" to send a system invitation with a default role.
- The SuperAdmin can edit a user to change their role (e.g., from `Manager` to `Admin`).
- The SuperAdmin can toggle a user's status to "Inactive" (preventing login instantly).
- Non-SuperAdmins attempting to access this view receive a 403 Forbidden error.

### US-02: Dashboard Analytics Overview
**As a** Manager or Admin,
**I want to** see real-time statistics of daily sales, active orders, and low-stock products on the dashboard home screen,
**So that** I can make quick operational decisions upon logging in.

## 4. Non-Functional Requirements
- **Security:** Passwords must be hashed using Argon2 or BCrypt. APIs must enforce HTTPS.
- **Performance:** Dashboard API endpoints must return within 200ms at P95 under standard load.
- **Audit:** All role changes by the SuperAdmin must be logged in an `AuditLogs` table for compliance.
