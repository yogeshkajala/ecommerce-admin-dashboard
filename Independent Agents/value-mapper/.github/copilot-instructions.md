# Value Mapper -- Workspace Configuration

## Overview
This workspace includes the **Value Mapper** agent. Use when mapping value streams, identifying value drivers, analyzing how technology investments create business value, or comparing current vs future state.

## Agent Invocation
- Use `@value-mapper` to invoke the agent directly
- Use `/value-mapper.prompt` for guided workflow prompts
- Use `/value-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `VALUE_MAPPER_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `VALUE_MAPPER_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `VALUE_MAPPER_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `VALUE_MAPPER_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `VALUE_MAPPER_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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