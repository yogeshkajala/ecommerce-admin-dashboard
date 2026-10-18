# Service Mesh Setup -- Workspace Configuration

## Overview
This workspace includes the **Service Mesh Setup** agent. Use when configuring service mesh for microservice communication, mTLS, circuit breaking, and observability.

## Agent Invocation
- Use `@service-mesh-setup` to invoke the agent directly
- Use `/service-mesh-setup.prompt` for guided workflow prompts
- Use `/service-mesh-setup-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_MESH_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `SERVICE_MESH_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `SERVICE_MESH_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `SERVICE_MESH_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `SERVICE_MESH_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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