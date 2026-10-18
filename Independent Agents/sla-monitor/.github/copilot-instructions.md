# Sla Monitor -- Workspace Configuration

## Overview
This workspace includes the **Sla Monitor** agent. Use when monitoring SLA/SLO adherence, tracking error budgets, alerting on burn rate, or reporting reliability metrics.

## Agent Invocation
- Use `@sla-monitor` to invoke the agent directly
- Use `/sla-monitor.prompt` for guided workflow prompts
- Use `/sla-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SLA_MONITOR_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `SLA_MONITOR_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `SLA_MONITOR_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `SLA_MONITOR_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `SLA_MONITOR_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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