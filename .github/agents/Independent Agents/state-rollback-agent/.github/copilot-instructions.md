# State Rollback Agent -- Workspace Configuration

## Overview
This workspace includes the **State Rollback Agent** agent. Use when reverting system components to pre-upgrade state using verified snapshots and rollback procedures.

## Agent Invocation
- Use `@state-rollback-agent` to invoke the agent directly
- Use `/state-rollback-agent.prompt` for guided workflow prompts
- Use `/state-rollback-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STATE_ROLLBA_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `STATE_ROLLBA_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `STATE_ROLLBA_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `STATE_ROLLBA_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `STATE_ROLLBA_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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