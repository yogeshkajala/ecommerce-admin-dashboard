# Architecture Designer -- Workspace Configuration

## Overview
This workspace includes the **Architecture Designer** agent. Design system architecture: components, patterns, technology selection, and scalability.

## Agent Invocation
- Use `@architecture-designer` to invoke the agent directly
- Use `/architecture-designer.prompt` for guided workflow prompts
- Use `/architecture-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ARCHITECTURE_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `ARCHITECTURE_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `ARCHITECTURE_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `ARCHITECTURE_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `ARCHITECTURE_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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