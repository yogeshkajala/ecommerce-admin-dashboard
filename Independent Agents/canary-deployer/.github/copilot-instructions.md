# Canary Deployer -- Workspace Configuration

## Overview
This workspace includes the **Canary Deployer** agent. Use when executing canary or progressive deployments with traffic shifting and health monitoring.

## Agent Invocation
- Use `@canary-deployer` to invoke the agent directly
- Use `/canary-deployer.prompt` for guided workflow prompts
- Use `/canary-deployer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CANARY_DEPLO_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `CANARY_DEPLO_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `CANARY_DEPLO_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `CANARY_DEPLO_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `CANARY_DEPLO_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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