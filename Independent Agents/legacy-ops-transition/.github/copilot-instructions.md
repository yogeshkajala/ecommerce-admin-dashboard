# Legacy Ops Transition -- Workspace Configuration

## Overview
This workspace includes the **Legacy Ops Transition** agent. Use when managing the operational transition from legacy systems including knowledge transfer, decommissioning, monitoring migration, and support handover.

## Agent Invocation
- Use `@legacy-ops-transition` to invoke the agent directly
- Use `/legacy-ops-transition.prompt` for guided workflow prompts
- Use `/legacy-ops-transition-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_OPS_T_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `LEGACY_OPS_T_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `LEGACY_OPS_T_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `LEGACY_OPS_T_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `LEGACY_OPS_T_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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