# State Restorer -- Workspace Configuration

## Overview
This workspace includes the **State Restorer** agent. Use when restoring application or database state after rollback to ensure data consistency with the reverted version.

## Agent Invocation
- Use `@state-restorer` to invoke the agent directly
- Use `/state-restorer.prompt` for guided workflow prompts
- Use `/state-restorer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STATE_RESTOR_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `STATE_RESTOR_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `STATE_RESTOR_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `STATE_RESTOR_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `STATE_RESTOR_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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