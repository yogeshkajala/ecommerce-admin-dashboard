# Deploy Executor -- Workspace Configuration

## Overview
This workspace includes the **Deploy Executor** agent. Use when executing deployments with progressive rollout strategies, traffic management, feature flags, and rollback capability.

## Agent Invocation
- Use `@deploy-executor` to invoke the agent directly
- Use `/deploy-executor.prompt` for guided workflow prompts
- Use `/deploy-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPLOY_EXECU_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `DEPLOY_EXECU_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `DEPLOY_EXECU_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `DEPLOY_EXECU_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `DEPLOY_EXECU_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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