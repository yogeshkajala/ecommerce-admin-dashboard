# Legacy Requirements Analyst -- Workspace Configuration

## Overview
This workspace includes the **Legacy Requirements Analyst** agent. Use when analyzing legacy system requirements including mining documentation, extracting business rules, cataloging interfaces, and building data dictionaries.

## Agent Invocation
- Use `@legacy-requirements-analyst` to invoke the agent directly
- Use `/legacy-requirements-analyst.prompt` for guided workflow prompts
- Use `/legacy-requirements-analyst-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_REQUI_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `LEGACY_REQUI_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `LEGACY_REQUI_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `LEGACY_REQUI_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `LEGACY_REQUI_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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