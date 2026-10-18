# Data Replicator -- Workspace Configuration

## Overview
This workspace includes the **Data Replicator** agent. Replicate data to cloud with continuous sync until cutover: DMS, logical replication.

## Agent Invocation
- Use `@data-replicator` to invoke the agent directly
- Use `/data-replicator.prompt` for guided workflow prompts
- Use `/data-replicator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_REPLICA_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `DATA_REPLICA_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `DATA_REPLICA_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `DATA_REPLICA_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `DATA_REPLICA_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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