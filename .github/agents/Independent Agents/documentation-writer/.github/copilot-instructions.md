# Documentation Writer -- Workspace Configuration

## Overview
This workspace includes the **Documentation Writer** agent. Use when updating documentation for new features including API docs, user guides, migration guides, and changelog entries.

## Agent Invocation
- Use `@documentation-writer` to invoke the agent directly
- Use `/documentation-writer.prompt` for guided workflow prompts
- Use `/documentation-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DOCUMENTATIO_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `DOCUMENTATIO_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `DOCUMENTATIO_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `DOCUMENTATIO_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `DOCUMENTATIO_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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