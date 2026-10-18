# Devops Engineer -- Workspace Configuration

## Overview
This workspace includes the **Devops Engineer** agent. Use when setting up CI/CD pipelines, infrastructure as code, deployment automation, and environment management for new development projects.

## Agent Invocation
- Use `@devops-engineer` to invoke the agent directly
- Use `/devops-engineer.prompt` for guided workflow prompts
- Use `/devops-engineer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEVOPS_ENGIN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `DEVOPS_ENGIN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `DEVOPS_ENGIN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `DEVOPS_ENGIN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `DEVOPS_ENGIN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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