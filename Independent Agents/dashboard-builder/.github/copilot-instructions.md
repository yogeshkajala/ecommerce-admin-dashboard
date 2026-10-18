# Dashboard Builder -- Workspace Configuration

## Overview
This workspace includes the **Dashboard Builder** agent. Build project dashboards with metrics, charts, and visualizations for stakeholders.

## Agent Invocation
- Use `@dashboard-builder` to invoke the agent directly
- Use `/dashboard-builder.prompt` for guided workflow prompts
- Use `/dashboard-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DASHBOARD_BU_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `DASHBOARD_BU_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `DASHBOARD_BU_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `DASHBOARD_BU_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `DASHBOARD_BU_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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