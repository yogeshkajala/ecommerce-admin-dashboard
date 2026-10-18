# Change Window Planner -- Workspace Configuration

## Overview
This workspace includes the **Change Window Planner** agent. Use when scheduling deployment change windows considering traffic patterns, business events, and team availability.

## Agent Invocation
- Use `@change-window-planner` to invoke the agent directly
- Use `/change-window-planner.prompt` for guided workflow prompts
- Use `/change-window-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CHANGE_WINDO_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `CHANGE_WINDO_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `CHANGE_WINDO_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `CHANGE_WINDO_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `CHANGE_WINDO_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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