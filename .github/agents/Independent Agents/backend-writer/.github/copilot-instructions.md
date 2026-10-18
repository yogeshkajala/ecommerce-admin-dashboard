# Backend Writer -- Workspace Configuration

## Overview
This workspace includes the **Backend Writer** agent. Use when generating server-side code: REST APIs, GraphQL resolvers, services, repositories, middleware, DTOs, and validation logic.

## Agent Invocation
- Use `@backend-writer` to invoke the agent directly
- Use `/backend-writer.prompt` for guided workflow prompts
- Use `/backend-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BACKEND_WRIT_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `BACKEND_WRIT_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `BACKEND_WRIT_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `BACKEND_WRIT_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `BACKEND_WRIT_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

## Key Conventions
- Cross-signal correlation is enabled by default (metrics + logs + traces)
- Anomaly detection uses configured sensitivity level
- Dashboards auto-generated for new services
- Alerts are deduplicated within the configured window
- Telemetry retention follows configured retention period

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations