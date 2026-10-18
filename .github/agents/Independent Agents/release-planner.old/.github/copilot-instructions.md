# Release Planner -- Workspace Configuration

## Overview
This workspace includes the **Release Planner** agent. Plan releases with scope definition, milestones, feature readiness, and go-live criteria.

## Agent Invocation
- Use `@release-planner` to invoke the agent directly
- Use `/release-planner.prompt` for guided workflow prompts
- Use `/release-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RELEASE_PLAN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `RELEASE_PLAN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `RELEASE_PLAN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `RELEASE_PLAN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `RELEASE_PLAN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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