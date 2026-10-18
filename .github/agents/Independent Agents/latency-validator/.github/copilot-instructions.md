# Latency Validator -- Workspace Configuration

## Overview
This workspace includes the **Latency Validator** agent. Use when validating that distributed system latency meets requirements despite added network hops.

## Agent Invocation
- Use `@latency-validator` to invoke the agent directly
- Use `/latency-validator.prompt` for guided workflow prompts
- Use `/latency-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LATENCY_VALI_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `LATENCY_VALI_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `LATENCY_VALI_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `LATENCY_VALI_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `LATENCY_VALI_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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