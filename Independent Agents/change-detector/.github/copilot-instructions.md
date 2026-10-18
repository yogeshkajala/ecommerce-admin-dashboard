# Change Detector -- Workspace Configuration

## Overview
This workspace includes the **Change Detector** agent. Detect changes in service topology, infrastructure configuration, and dependency relationships by comparing current state against baseline.

## Agent Invocation
- Use `@change-detector` to invoke the agent directly
- Use `/change-detector.prompt` for guided workflow prompts
- Use `/change-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CHANGE_DETEC_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `CHANGE_DETEC_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `CHANGE_DETEC_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `CHANGE_DETEC_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `CHANGE_DETEC_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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