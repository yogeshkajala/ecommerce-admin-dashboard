# Traffic Manager -- Workspace Configuration

## Overview
This workspace includes the **Traffic Manager** agent. Use when managing traffic routing during deployments including weighted routing, header-based routing, and traffic mirroring.

## Agent Invocation
- Use `@traffic-manager` to invoke the agent directly
- Use `/traffic-manager.prompt` for guided workflow prompts
- Use `/traffic-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TRAFFIC_MANA_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `TRAFFIC_MANA_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `TRAFFIC_MANA_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `TRAFFIC_MANA_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `TRAFFIC_MANA_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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