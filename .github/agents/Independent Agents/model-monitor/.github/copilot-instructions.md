# Model Monitor -- Workspace Configuration

## Overview
This workspace includes the **Model Monitor** agent. Use when monitoring production model performance, detecting data drift, concept drift, or evaluating prediction quality degradation.

## Agent Invocation
- Use `@model-monitor` to invoke the agent directly
- Use `/model-monitor.prompt` for guided workflow prompts
- Use `/model-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODEL_MONITO_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `MODEL_MONITO_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `MODEL_MONITO_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `MODEL_MONITO_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `MODEL_MONITO_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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