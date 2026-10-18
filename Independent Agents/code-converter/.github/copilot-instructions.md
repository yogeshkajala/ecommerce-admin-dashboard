# Code Converter -- Workspace Configuration

## Overview
This workspace includes the **Code Converter** agent. Convert legacy code (COBOL, VB6, etc.) to modern languages preserving logic.

## Agent Invocation
- Use `@code-converter` to invoke the agent directly
- Use `/code-converter.prompt` for guided workflow prompts
- Use `/code-converter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_CONVERT_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `CODE_CONVERT_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `CODE_CONVERT_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `CODE_CONVERT_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `CODE_CONVERT_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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