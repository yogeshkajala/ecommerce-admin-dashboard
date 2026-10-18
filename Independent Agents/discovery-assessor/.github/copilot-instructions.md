# Discovery Assessor -- Workspace Configuration

## Overview
This workspace includes the **Discovery Assessor** agent. Use when conducting application portfolio discovery, cataloging current-state applications, assessing tech stack, dependencies, data stores, and integration patterns.

## Agent Invocation
- Use `@discovery-assessor` to invoke the agent directly
- Use `/discovery-assessor.prompt` for guided workflow prompts
- Use `/discovery-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DISCOVERY_AS_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `DISCOVERY_AS_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `DISCOVERY_AS_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `DISCOVERY_AS_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `DISCOVERY_AS_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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