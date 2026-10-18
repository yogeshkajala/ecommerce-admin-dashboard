# Deployment Executor -- Workspace Configuration

## Overview
This workspace includes the **Deployment Executor** agent. Use when executing deployments using canary, blue-green, or rolling strategies with health check validation and traffic management.

## Agent Invocation
- Use `@deployment-executor` to invoke the agent directly
- Use `/deployment-executor.prompt` for guided workflow prompts
- Use `/deployment-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPLOYMENT_E_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `DEPLOYMENT_E_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `DEPLOYMENT_E_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `DEPLOYMENT_E_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `DEPLOYMENT_E_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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