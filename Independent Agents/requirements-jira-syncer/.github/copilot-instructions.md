# Requirements Jira Syncer -- Workspace Configuration

## Overview
This workspace includes the **Requirements Jira Syncer** agent. Sync requirements to Jira: create epics, stories, acceptance criteria, and traceability links.

## Agent Invocation
- Use `@requirements-jira-syncer` to invoke the agent directly
- Use `/requirements-jira-syncer.prompt` for guided workflow prompts
- Use `/requirements-jira-syncer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REQUIREMENTS_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `REQUIREMENTS_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `REQUIREMENTS_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `REQUIREMENTS_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `REQUIREMENTS_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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