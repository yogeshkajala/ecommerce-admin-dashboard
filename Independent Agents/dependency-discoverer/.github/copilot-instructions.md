# Dependency Discoverer -- Workspace Configuration

## Overview
This workspace includes the **Dependency Discoverer** agent. Discover service dependencies from distributed traces, network telemetry, configuration files, and infrastructure metadata.

## Agent Invocation
- Use `@dependency-discoverer` to invoke the agent directly
- Use `/dependency-discoverer.prompt` for guided workflow prompts
- Use `/dependency-discoverer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_D_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `DEPENDENCY_D_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `DEPENDENCY_D_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `DEPENDENCY_D_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `DEPENDENCY_D_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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