# Pipeline Engineer -- Workspace Configuration

## Overview
This workspace includes the **Pipeline Engineer** agent. Use when designing and implementing CI/CD pipelines including build, test, scan, and deployment stages.

## Agent Invocation
- Use `@pipeline-engineer` to invoke the agent directly
- Use `/pipeline-engineer.prompt` for guided workflow prompts
- Use `/pipeline-engineer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PIPELINE_ENG_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `PIPELINE_ENG_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `PIPELINE_ENG_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `PIPELINE_ENG_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `PIPELINE_ENG_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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