# Workload Cataloger -- Workspace Configuration

## Overview
This workspace includes the **Workload Cataloger** agent. Use when discovering and cataloging infrastructure workloads with compute, storage, network, and dependency metadata.

## Agent Invocation
- Use `@workload-cataloger` to invoke the agent directly
- Use `/workload-cataloger.prompt` for guided workflow prompts
- Use `/workload-cataloger-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `WORKLOAD_CAT_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `WORKLOAD_CAT_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `WORKLOAD_CAT_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `WORKLOAD_CAT_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `WORKLOAD_CAT_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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