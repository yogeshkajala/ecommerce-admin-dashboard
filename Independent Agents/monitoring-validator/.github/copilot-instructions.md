# Monitoring Validator -- Workspace Configuration

## Overview
This workspace includes the **Monitoring Validator** agent. Use when verifying that monitoring, alerting, and dashboards are correctly configured for newly deployed services.

## Agent Invocation
- Use `@monitoring-validator` to invoke the agent directly
- Use `/monitoring-validator.prompt` for guided workflow prompts
- Use `/monitoring-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MONITORING_V_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `MONITORING_V_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `MONITORING_V_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `MONITORING_V_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `MONITORING_V_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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