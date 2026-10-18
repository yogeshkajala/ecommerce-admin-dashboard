# Log Correlator -- Workspace Configuration

## Overview
This workspace includes the **Log Correlator** agent. Correlate logs across distributed services using trace IDs and timestamps.

## Agent Invocation
- Use `@log-correlator` to invoke the agent directly
- Use `/log-correlator.prompt` for guided workflow prompts
- Use `/log-correlator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LOG_CORRELAT_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `LOG_CORRELAT_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `LOG_CORRELAT_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `LOG_CORRELAT_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `LOG_CORRELAT_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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