# Vision Definer -- Workspace Configuration

## Overview
This workspace includes the **Vision Definer** agent. Define product vision, mission, target audience, and success metrics.

## Agent Invocation
- Use `@vision-definer` to invoke the agent directly
- Use `/vision-definer.prompt` for guided workflow prompts
- Use `/vision-definer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `VISION_DEFIN_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `VISION_DEFIN_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `VISION_DEFIN_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `VISION_DEFIN_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `VISION_DEFIN_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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