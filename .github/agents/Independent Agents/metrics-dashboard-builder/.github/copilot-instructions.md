# Metrics Dashboard Builder -- Workspace Configuration

## Overview
This workspace includes the **Metrics Dashboard Builder** agent. Use when building metrics dashboards, defining KPIs, generating visualization data for charts, or tracking program health indicators over time.

## Agent Invocation
- Use `@metrics-dashboard-builder` to invoke the agent directly
- Use `/metrics-dashboard-builder.prompt` for guided workflow prompts
- Use `/metrics-dashboard-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `METRICS_DASH_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `METRICS_DASH_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `METRICS_DASH_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `METRICS_DASH_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `METRICS_DASH_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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