# Metric Collector -- Workspace Configuration

## Overview
This workspace includes the **Metric Collector** agent. Collect and analyze infrastructure and application metrics.

## Agent Invocation
- Use `@metric-collector` to invoke the agent directly
- Use `/metric-collector.prompt` for guided workflow prompts
- Use `/metric-collector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `METRIC_COLLE_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `METRIC_COLLE_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `METRIC_COLLE_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `METRIC_COLLE_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `METRIC_COLLE_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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