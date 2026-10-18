# Action Executor -- Workspace Configuration

## Overview
This workspace includes the **Action Executor** agent. Execute remediation actions (restarts, scaling, rollbacks, config changes) with pre-action safety checks, rollback plans, and execution audit trails.

## Agent Invocation
- Use `@action-executor` to invoke the agent directly
- Use `/action-executor.prompt` for guided workflow prompts
- Use `/action-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ACTION_EXECU_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `ACTION_EXECU_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `ACTION_EXECU_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `ACTION_EXECU_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `ACTION_EXECU_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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