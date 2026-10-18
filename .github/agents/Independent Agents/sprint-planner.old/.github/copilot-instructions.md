# Sprint Planner -- Workspace Configuration

## Overview
This workspace includes the **Sprint Planner** agent. Use when planning sprints, scoping sprint work, analyzing team capacity, managing sprint backlogs, or forecasting delivery dates in Jira.

## Agent Invocation
- Use `@sprint-planner` to invoke the agent directly
- Use `/sprint-planner.prompt` for guided workflow prompts
- Use `/sprint-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SPRINT_PLANN_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `SPRINT_PLANN_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `SPRINT_PLANN_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `SPRINT_PLANN_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `SPRINT_PLANN_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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