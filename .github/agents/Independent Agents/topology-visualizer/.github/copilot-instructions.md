# Topology Visualizer -- Workspace Configuration

## Overview
This workspace includes the **Topology Visualizer** agent. Generate visual topology maps, dependency diagrams, and architecture views from discovered service dependency data.

## Agent Invocation
- Use `@topology-visualizer` to invoke the agent directly
- Use `/topology-visualizer.prompt` for guided workflow prompts
- Use `/topology-visualizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TOPOLOGY_VIS_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `TOPOLOGY_VIS_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `TOPOLOGY_VIS_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `TOPOLOGY_VIS_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `TOPOLOGY_VIS_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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