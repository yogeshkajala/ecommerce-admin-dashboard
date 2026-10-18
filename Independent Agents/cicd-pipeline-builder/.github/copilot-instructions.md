# Cicd Pipeline Builder -- Workspace Configuration

## Overview
This workspace includes the **Cicd Pipeline Builder** agent. Use when building CI/CD pipelines for modernized application deployment with quality gates and progressive rollout stages.

## Agent Invocation
- Use `@cicd-pipeline-builder` to invoke the agent directly
- Use `/cicd-pipeline-builder.prompt` for guided workflow prompts
- Use `/cicd-pipeline-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CICD_PIPELIN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `CICD_PIPELIN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `CICD_PIPELIN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `CICD_PIPELIN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `CICD_PIPELIN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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