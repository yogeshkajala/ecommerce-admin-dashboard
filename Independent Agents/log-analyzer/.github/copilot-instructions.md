# Log Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Log Analyzer** agent. Use when parsing application logs, correlating log entries by request ID, extracting error patterns, or analyzing log volume anomalies.

## Agent Invocation
- Use `@log-analyzer` to invoke the agent directly
- Use `/log-analyzer.prompt` for guided workflow prompts
- Use `/log-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LOG_ANALYZER_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `LOG_ANALYZER_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `LOG_ANALYZER_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `LOG_ANALYZER_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `LOG_ANALYZER_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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