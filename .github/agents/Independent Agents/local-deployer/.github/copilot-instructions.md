# Local Deployer -- Workspace Configuration

## Overview
This workspace includes the **Local Deployer** agent. Deploy locally using Docker, docker-compose, and local development tooling.

## Agent Invocation
- Use `@local-deployer` to invoke the agent directly
- Use `/local-deployer.prompt` for guided workflow prompts
- Use `/local-deployer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LOCAL_DEPLOY_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `LOCAL_DEPLOY_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `LOCAL_DEPLOY_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `LOCAL_DEPLOY_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `LOCAL_DEPLOY_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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