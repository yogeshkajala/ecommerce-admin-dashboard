# Interface Cataloger -- Workspace Configuration

## Overview
This workspace includes the **Interface Cataloger** agent. Use when cataloging legacy system interfaces including APIs, file transfers, message queues, and database links.

## Agent Invocation
- Use `@interface-cataloger` to invoke the agent directly
- Use `/interface-cataloger.prompt` for guided workflow prompts
- Use `/interface-cataloger-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INTERFACE_CA_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `INTERFACE_CA_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `INTERFACE_CA_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `INTERFACE_CA_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `INTERFACE_CA_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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