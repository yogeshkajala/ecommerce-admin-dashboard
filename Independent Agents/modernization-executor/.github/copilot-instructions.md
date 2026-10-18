# Modernization Executor -- Workspace Configuration

## Overview
This workspace includes the **Modernization Executor** agent. Use when executing cloud modernization including containerization, service mesh configuration, CI/CD modernization, and observability integration.

## Agent Invocation
- Use `@modernization-executor` to invoke the agent directly
- Use `/modernization-executor.prompt` for guided workflow prompts
- Use `/modernization-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODERNIZATIO_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `MODERNIZATIO_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `MODERNIZATIO_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `MODERNIZATIO_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `MODERNIZATIO_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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