# Upgrade Ops Monitor -- Workspace Configuration

## Overview
This workspace includes the **Upgrade Ops Monitor** agent. Use when monitoring post-upgrade operations -- metric comparison, error tracking, SLA verification, and user feedback collection.

## Agent Invocation
- Use `@upgrade-ops-monitor` to invoke the agent directly
- Use `/upgrade-ops-monitor.prompt` for guided workflow prompts
- Use `/upgrade-ops-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UPGRADE_OPS__RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `UPGRADE_OPS__ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `UPGRADE_OPS__CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `UPGRADE_OPS__DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `UPGRADE_OPS__ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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