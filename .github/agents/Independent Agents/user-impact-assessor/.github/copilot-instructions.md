# User Impact Assessor -- Workspace Configuration

## Overview
This workspace includes the **User Impact Assessor** agent. Use when assessing user impact from post-deployment anomalies including business KPI changes, user experience degradation, and conversion impacts.

## Agent Invocation
- Use `@user-impact-assessor` to invoke the agent directly
- Use `/user-impact-assessor.prompt` for guided workflow prompts
- Use `/user-impact-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `USER_IMPACT__STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `USER_IMPACT__HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `USER_IMPACT__ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `USER_IMPACT__APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `USER_IMPACT__NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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