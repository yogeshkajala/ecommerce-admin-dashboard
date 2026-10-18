# Backlog Manager -- Workspace Configuration

## Overview
This workspace includes the **Backlog Manager** agent. Manage product backlog: ordering, grooming, dependency tracking, debt management.

## Agent Invocation
- Use `@backlog-manager` to invoke the agent directly
- Use `/backlog-manager.prompt` for guided workflow prompts
- Use `/backlog-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BACKLOG_MANA_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `BACKLOG_MANA_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `BACKLOG_MANA_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `BACKLOG_MANA_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `BACKLOG_MANA_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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