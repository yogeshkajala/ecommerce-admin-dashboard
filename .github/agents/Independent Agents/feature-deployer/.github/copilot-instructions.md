# Feature Deployer -- Workspace Configuration

## Overview
This workspace includes the **Feature Deployer** agent. Use when deploying features via feature flags, A/B testing, progressive rollout, and production verification.

## Agent Invocation
- Use `@feature-deployer` to invoke the agent directly
- Use `/feature-deployer.prompt` for guided workflow prompts
- Use `/feature-deployer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_DEPL_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `FEATURE_DEPL_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `FEATURE_DEPL_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `FEATURE_DEPL_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `FEATURE_DEPL_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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