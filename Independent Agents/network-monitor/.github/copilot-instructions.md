# Network Monitor -- Workspace Configuration

## Overview
This workspace includes the **Network Monitor** agent. Monitor network health: connectivity, latency, throughput, and DNS.

## Agent Invocation
- Use `@network-monitor` to invoke the agent directly
- Use `/network-monitor.prompt` for guided workflow prompts
- Use `/network-monitor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `NETWORK_MONI_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `NETWORK_MONI_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `NETWORK_MONI_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `NETWORK_MONI_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `NETWORK_MONI_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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