# Breaking Change Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Breaking Change Analyzer** agent. Use when analyzing changelogs and migration guides to inventory all breaking changes between current and target versions.

## Agent Invocation
- Use `@breaking-change-analyzer` to invoke the agent directly
- Use `/breaking-change-analyzer.prompt` for guided workflow prompts
- Use `/breaking-change-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BREAKING_CHA_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `BREAKING_CHA_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `BREAKING_CHA_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `BREAKING_CHA_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `BREAKING_CHA_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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