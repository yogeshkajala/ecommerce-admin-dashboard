# Quality Metric Tracker -- Workspace Configuration

## Overview
This workspace includes the **Quality Metric Tracker** agent. Use when tracking and reporting project quality metrics including defect rates, code coverage, and process adherence.

## Agent Invocation
- Use `@quality-metric-tracker` to invoke the agent directly
- Use `/quality-metric-tracker.prompt` for guided workflow prompts
- Use `/quality-metric-tracker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `QUALITY_METR_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `QUALITY_METR_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `QUALITY_METR_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `QUALITY_METR_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `QUALITY_METR_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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