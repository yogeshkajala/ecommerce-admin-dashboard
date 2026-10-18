# Progressive Rollout Agent -- Workspace Configuration

## Overview
This workspace includes the **Progressive Rollout Agent** agent. Use when executing progressive feature rollouts with defined checkpoints, monitoring, and automatic rollback triggers.

## Agent Invocation
- Use `@progressive-rollout-agent` to invoke the agent directly
- Use `/progressive-rollout-agent.prompt` for guided workflow prompts
- Use `/progressive-rollout-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PROGRESSIVE__STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `PROGRESSIVE__HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `PROGRESSIVE__ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `PROGRESSIVE__APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `PROGRESSIVE__NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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