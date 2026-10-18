# Traffic Shifter -- Workspace Configuration

## Overview
This workspace includes the **Traffic Shifter** agent. Use when shifting traffic between deployment versions during rollback, canary, or blue-green operations.

## Agent Invocation
- Use `@traffic-shifter` to invoke the agent directly
- Use `/traffic-shifter.prompt` for guided workflow prompts
- Use `/traffic-shifter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TRAFFIC_SHIF_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `TRAFFIC_SHIF_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `TRAFFIC_SHIF_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `TRAFFIC_SHIF_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `TRAFFIC_SHIF_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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