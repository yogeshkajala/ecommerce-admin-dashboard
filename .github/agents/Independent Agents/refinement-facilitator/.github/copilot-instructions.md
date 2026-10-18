# Refinement Facilitator -- Workspace Configuration

## Overview
This workspace includes the **Refinement Facilitator** agent. Facilitate backlog refinement: story splitting, estimation, clarification.

## Agent Invocation
- Use `@refinement-facilitator` to invoke the agent directly
- Use `/refinement-facilitator.prompt` for guided workflow prompts
- Use `/refinement-facilitator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REFINEMENT_F_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `REFINEMENT_F_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `REFINEMENT_F_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `REFINEMENT_F_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `REFINEMENT_F_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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