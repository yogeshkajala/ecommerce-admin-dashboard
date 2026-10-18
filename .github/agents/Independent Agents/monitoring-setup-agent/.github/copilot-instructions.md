# Monitoring Setup Agent -- Workspace Configuration

## Overview
This workspace includes the **Monitoring Setup Agent** agent. Use when setting up monitoring dashboards, metric collection, and observability instrumentation for modernized services.

## Agent Invocation
- Use `@monitoring-setup-agent` to invoke the agent directly
- Use `/monitoring-setup-agent.prompt` for guided workflow prompts
- Use `/monitoring-setup-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MONITORING_S_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `MONITORING_S_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `MONITORING_S_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `MONITORING_S_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `MONITORING_S_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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