# Pipeline Builder -- Workspace Configuration

## Overview
This workspace includes the **Pipeline Builder** agent. Use when creating CI/CD pipeline definitions for building, testing, and deploying containerized services.

## Agent Invocation
- Use `@pipeline-builder` to invoke the agent directly
- Use `/pipeline-builder.prompt` for guided workflow prompts
- Use `/pipeline-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PIPELINE_BUI_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `PIPELINE_BUI_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `PIPELINE_BUI_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `PIPELINE_BUI_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `PIPELINE_BUI_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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