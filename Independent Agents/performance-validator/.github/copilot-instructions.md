# Performance Validator -- Workspace Configuration

## Overview
This workspace includes the **Performance Validator** agent. Use when comparing migrated workload performance against pre-migration baseline metrics.

## Agent Invocation
- Use `@performance-validator` to invoke the agent directly
- Use `/performance-validator.prompt` for guided workflow prompts
- Use `/performance-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PERFORMANCE__RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `PERFORMANCE__ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `PERFORMANCE__CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `PERFORMANCE__DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `PERFORMANCE__ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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