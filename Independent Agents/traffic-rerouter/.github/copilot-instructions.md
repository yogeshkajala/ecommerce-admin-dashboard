# Traffic Rerouter -- Workspace Configuration

## Overview
This workspace includes the **Traffic Rerouter** agent. Use when rerouting traffic during upgrade rollback to minimize user impact and enable zero-downtime recovery.

## Agent Invocation
- Use `@traffic-rerouter` to invoke the agent directly
- Use `/traffic-rerouter.prompt` for guided workflow prompts
- Use `/traffic-rerouter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TRAFFIC_RERO_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `TRAFFIC_RERO_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `TRAFFIC_RERO_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `TRAFFIC_RERO_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `TRAFFIC_RERO_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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