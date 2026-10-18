# User Feedback Collector -- Workspace Configuration

## Overview
This workspace includes the **User Feedback Collector** agent. Use when collecting and analyzing user feedback after upgrades to detect user-impacting issues not visible in technical metrics.

## Agent Invocation
- Use `@user-feedback-collector` to invoke the agent directly
- Use `/user-feedback-collector.prompt` for guided workflow prompts
- Use `/user-feedback-collector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `USER_FEEDBAC_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `USER_FEEDBAC_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `USER_FEEDBAC_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `USER_FEEDBAC_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `USER_FEEDBAC_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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