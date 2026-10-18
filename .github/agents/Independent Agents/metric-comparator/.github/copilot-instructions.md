# Metric Comparator -- Workspace Configuration

## Overview
This workspace includes the **Metric Comparator** agent. Use when comparing operational metrics between pre-upgrade baseline and post-upgrade live measurements.

## Agent Invocation
- Use `@metric-comparator` to invoke the agent directly
- Use `/metric-comparator.prompt` for guided workflow prompts
- Use `/metric-comparator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `METRIC_COMPA_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `METRIC_COMPA_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `METRIC_COMPA_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `METRIC_COMPA_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `METRIC_COMPA_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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