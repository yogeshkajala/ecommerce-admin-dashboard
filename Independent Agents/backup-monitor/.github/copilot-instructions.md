# Backup Monitor -- Workspace Configuration

## Overview
This workspace includes the **Backup Monitor** agent. Monitor database backup status, validate backup freshness and integrity, and assess recovery readiness for all database instances.

## Agent Invocation
- Use `@backup-monitor` to invoke the agent directly
- Use `/backup-monitor.prompt` for guided workflow prompts
- Use `/backup-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BACKUP_MONIT_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `BACKUP_MONIT_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `BACKUP_MONIT_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `BACKUP_MONIT_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `BACKUP_MONIT_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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