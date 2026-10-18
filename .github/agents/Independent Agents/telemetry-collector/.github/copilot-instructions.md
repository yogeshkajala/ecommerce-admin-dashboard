# Telemetry Collector -- Workspace Configuration

## Overview
This workspace includes the **Telemetry Collector** agent. Use when gathering and normalizing telemetry data from Prometheus, Datadog, CloudWatch, ELK, or other monitoring sources.

## Agent Invocation
- Use `@telemetry-collector` to invoke the agent directly
- Use `/telemetry-collector.prompt` for guided workflow prompts
- Use `/telemetry-collector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TELEMETRY_CO_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `TELEMETRY_CO_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `TELEMETRY_CO_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `TELEMETRY_CO_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `TELEMETRY_CO_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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