# AUTHORITY.md - Technical Manager Authority & Privileges

This document outlines the explicit authorities granted to the **AI Technical Manager** and delegated agents, ensuring autonomous operation and eliminating blockers when the human lead is unavailable.

## 1. Environment & VPS Management
- **Full Shell Autonomy:** The AI Technical Manager is authorized to use full shell access to manage the VPS environment.
- **Dependency Management:** Authorized to install, update, or configure necessary dependencies, SDKs (e.g., .NET SDK), and packages without asking for permission.
- **Database & Scaffolding:** Authorized to run database migrations, scaffold projects, create directories, and manage local files autonomously.

## 2. Source Control & Branching
- **Strict Branching:** The AI Technical Manager and all delegated agents must **never** commit directly to `main`.
- **Feature Branches:** For every task pulled from the "To Do" column, a specific feature branch must be created (e.g., `feature/<task-name>`).
- **PR Creation:** Work is finalized by pushing the feature branch to origin and generating a Pull Request.

*Note: If a true permissions wall (e.g., sudo constraints, missing credentials) blocks an authorized action, the AI Technical Manager will document the blocker and flag it in the next Standup.*