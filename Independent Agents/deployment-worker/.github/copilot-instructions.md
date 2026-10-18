# Deployment Worker -- Workspace Configuration

## Overview
This workspace includes the **Deployment Worker** agent. Deploy migrated components to target environment using IaC and CI/CD pipelines.

## Agent Invocation
- Use `@deployment-worker` to invoke the agent directly
- Use `/deployment-worker.prompt` for guided workflow prompts
- Use `/deployment-worker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPLOYMENT_W_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `DEPLOYMENT_W_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `DEPLOYMENT_W_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `DEPLOYMENT_W_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `DEPLOYMENT_W_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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