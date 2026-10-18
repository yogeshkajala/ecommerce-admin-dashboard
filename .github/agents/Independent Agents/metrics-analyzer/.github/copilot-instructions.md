# Metrics Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Metrics Analyzer** agent. Use when monitoring service metrics, detecting anomalies against baselines, tracking SLIs, or analyzing resource utilization.

## Agent Invocation
- Use `@metrics-analyzer` to invoke the agent directly
- Use `/metrics-analyzer.prompt` for guided workflow prompts
- Use `/metrics-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `METRICS_ANAL_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `METRICS_ANAL_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `METRICS_ANAL_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `METRICS_ANAL_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `METRICS_ANAL_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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