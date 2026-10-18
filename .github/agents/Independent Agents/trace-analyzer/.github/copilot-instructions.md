# Trace Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Trace Analyzer** agent. Analyze distributed traces for latency bottlenecks and error propagation.

## Agent Invocation
- Use `@trace-analyzer` to invoke the agent directly
- Use `/trace-analyzer.prompt` for guided workflow prompts
- Use `/trace-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TRACE_ANALYZ_RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `TRACE_ANALYZ_ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `TRACE_ANALYZ_CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `TRACE_ANALYZ_DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `TRACE_ANALYZ_ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

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