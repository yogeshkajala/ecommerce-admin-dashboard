# Environment Promoter -- Workspace Configuration

## Overview
This workspace includes the **Environment Promoter** agent. Use when promoting releases through dev, staging, and production environments with quality gate validation at each stage.

## Agent Invocation
- Use `@environment-promoter` to invoke the agent directly
- Use `/environment-promoter.prompt` for guided workflow prompts
- Use `/environment-promoter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ENVIRONMENT__STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `ENVIRONMENT__HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `ENVIRONMENT__ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `ENVIRONMENT__APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `ENVIRONMENT__NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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