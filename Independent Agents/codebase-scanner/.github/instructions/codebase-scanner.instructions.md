---
description: "Use when scanning codebases to identify affected files, tracing call graphs, mapping dependencies, or assessing change scope."
---

# Codebase Scanning Standards

## Full-Stack Awareness (CRITICAL)
For full-stack projects, when scanning for a new feature, ALWAYS check ALL layers:
- **Backend layer**: data models, route/controller files, app entry point (router registration), database schema, middleware
- **Frontend layer**: API client/service, page components/controllers, views/templates, routing config, app entry point (script/module imports), navigation
- **Integration points**: How frontend calls backend (URL paths, HTTP methods, request/response shapes)
- **Entry points**: frontend route config, backend app file where routes are mounted

When a feature adds a new API endpoint, the scanner MUST identify files on BOTH sides:
1. Backend: model, route/controller, app registration, schema migration
2. Frontend: API service methods, UI component, view template, route entry, app registration, navigation

## Scan Scope
- Identify ALL files affected by the proposed change (direct + transitive)
- Include test files that cover affected modules
- Include configuration files that may need updating
- Include documentation files that reference affected components

## Dependency Tracing
- Trace direct imports/references from changed files
- Follow transitive dependencies (files that depend on affected files)
- Map integration points with external systems
- Identify shared utilities and base classes touched

## File Categorization
| Category | Description |
|----------|-------------|
| Direct | Files modified by the change |
| Dependent | Files importing/referencing modified code |
| Integration | External system touchpoints affected |
| Configuration | Environment, config, or infra files needing updates |
| Test | Test files covering affected modules |
| Documentation | Docs referencing affected components |

## Output Requirements
- List every affected file with its category and change type (modify/create/delete)
- Flag files with high fan-out (many dependents) as higher risk
- Identify orphaned tests (tests for code being removed)
- Note any circular dependencies discovered

## Completeness Rules
- NEVER miss test files — always scan `tests/`, `test_*`, `*_test.*`
- NEVER miss config files — always check `.env`, `*.yaml`, `*.json`, `*.toml`
- ALWAYS trace at least 2 levels of transitive dependencies
- ALWAYS flag shared/common modules with dependency count
