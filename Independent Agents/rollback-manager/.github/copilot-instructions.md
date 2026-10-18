# Rollback Manager -- Workspace Configuration

## Overview
This workspace includes the **Rollback Manager** agent. Use when preparing, testing, or executing deployment rollbacks for failed or degraded releases.

## Agent Invocation
- Use `@rollback-manager` to invoke the agent directly
- Use `/rollback-manager.prompt` for guided workflow prompts
- Use `/rollback-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROLLBACK_MAN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `ROLLBACK_MAN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `ROLLBACK_MAN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `ROLLBACK_MAN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `ROLLBACK_MAN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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