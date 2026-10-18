# Observability Monitor -- Workspace Configuration

## Overview
This workspace includes the **Observability Monitor** agent. Use when monitoring system health, analyzing logs, checking metrics, correlating traces, or investigating observability signals across production services.

## Agent Invocation
- Use `@observability-monitor` to invoke the agent directly
- Use `/observability-monitor.prompt` for guided workflow prompts
- Use `/observability-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `OBSERVABILIT_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `OBSERVABILIT_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `OBSERVABILIT_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `OBSERVABILIT_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `OBSERVABILIT_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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