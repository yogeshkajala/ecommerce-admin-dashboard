# Connection Monitor -- Workspace Configuration

## Overview
This workspace includes the **Connection Monitor** agent. Monitor database connection pools, detect connection leaks, track utilization, and troubleshoot connection-related issues.

## Agent Invocation
- Use `@connection-monitor` to invoke the agent directly
- Use `/connection-monitor.prompt` for guided workflow prompts
- Use `/connection-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONNECTION_M_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `CONNECTION_M_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `CONNECTION_M_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `CONNECTION_M_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `CONNECTION_M_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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