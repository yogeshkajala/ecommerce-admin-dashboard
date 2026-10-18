# Health Checker -- Workspace Configuration

## Overview
This workspace includes the **Health Checker** agent. Use when verifying service health through endpoint checks, dependency connectivity, and resource utilization monitoring.

## Agent Invocation
- Use `@health-checker` to invoke the agent directly
- Use `/health-checker.prompt` for guided workflow prompts
- Use `/health-checker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `HEALTH_CHECK_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `HEALTH_CHECK_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `HEALTH_CHECK_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `HEALTH_CHECK_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `HEALTH_CHECK_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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