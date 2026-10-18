# Production Verifier -- Workspace Configuration

## Overview
This workspace includes the **Production Verifier** agent. Use when verifying production health after feature deployment including SLO compliance, error rates, and user impact.

## Agent Invocation
- Use `@production-verifier` to invoke the agent directly
- Use `/production-verifier.prompt` for guided workflow prompts
- Use `/production-verifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PRODUCTION_V_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `PRODUCTION_V_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `PRODUCTION_V_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `PRODUCTION_V_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `PRODUCTION_V_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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