# Dashboard Creator -- Workspace Configuration

## Overview
This workspace includes the **Dashboard Creator** agent. Use when creating Jira dashboards with JQL saved filters and gadgets for executive, weekly, or daily views. Supports Jira Cloud and Data Center.

## Agent Invocation
- Use `@dashboard-creator` to invoke the agent directly
- Use `/dashboard-creator.prompt` for guided workflow prompts
- Use `/dashboard-creator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DASHBOARD_CR_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `DASHBOARD_CR_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `DASHBOARD_CR_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `DASHBOARD_CR_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `DASHBOARD_CR_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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