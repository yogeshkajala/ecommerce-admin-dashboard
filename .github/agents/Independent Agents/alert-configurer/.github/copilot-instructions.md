# Alert Configurer -- Workspace Configuration

## Overview
This workspace includes the **Alert Configurer** agent. Use when configuring alert rules, thresholds, and escalation policies for modernized services.

## Agent Invocation
- Use `@alert-configurer` to invoke the agent directly
- Use `/alert-configurer.prompt` for guided workflow prompts
- Use `/alert-configurer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ALERT_CONFIG_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `ALERT_CONFIG_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `ALERT_CONFIG_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `ALERT_CONFIG_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `ALERT_CONFIG_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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