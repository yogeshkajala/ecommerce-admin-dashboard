# Metric Watcher -- Workspace Configuration

## Overview
This workspace includes the **Metric Watcher** agent. Use when watching deployment metrics for anomalies, trends, and deviations from baseline after deployment.

## Agent Invocation
- Use `@metric-watcher` to invoke the agent directly
- Use `/metric-watcher.prompt` for guided workflow prompts
- Use `/metric-watcher-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `METRIC_WATCH_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `METRIC_WATCH_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `METRIC_WATCH_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `METRIC_WATCH_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `METRIC_WATCH_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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