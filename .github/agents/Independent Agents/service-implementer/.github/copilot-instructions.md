# Service Implementer -- Workspace Configuration

## Overview
This workspace includes the **Service Implementer** agent. Implement microservices with proper domain logic, API contracts, and error handling.

## Agent Invocation
- Use `@service-implementer` to invoke the agent directly
- Use `/service-implementer.prompt` for guided workflow prompts
- Use `/service-implementer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_IMPL_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `SERVICE_IMPL_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `SERVICE_IMPL_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `SERVICE_IMPL_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `SERVICE_IMPL_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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