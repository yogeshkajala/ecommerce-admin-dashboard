# Code Translator -- Workspace Configuration

## Overview
This workspace includes the **Code Translator** agent. Use when translating legacy code to modern languages while preserving business logic and behavior.

## Agent Invocation
- Use `@code-translator` to invoke the agent directly
- Use `/code-translator.prompt` for guided workflow prompts
- Use `/code-translator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_TRANSLA_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `CODE_TRANSLA_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `CODE_TRANSLA_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `CODE_TRANSLA_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `CODE_TRANSLA_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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