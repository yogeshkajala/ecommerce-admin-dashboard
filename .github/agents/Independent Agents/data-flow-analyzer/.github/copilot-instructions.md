# Data Flow Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Data Flow Analyzer** agent. Map data flows, ETL pipelines, data transformations, and data lineage across systems.

## Agent Invocation
- Use `@data-flow-analyzer` to invoke the agent directly
- Use `/data-flow-analyzer.prompt` for guided workflow prompts
- Use `/data-flow-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_FLOW_AN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `DATA_FLOW_AN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `DATA_FLOW_AN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `DATA_FLOW_AN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `DATA_FLOW_AN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

## Key Conventions
- All production deployments require approval unless configured otherwise
- Automatic rollback on health check failure
- Deployment notifications sent to configured channel
- Blue-green and canary strategies validate before full cutover
- Deployment artifacts must be versioned and immutable

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations