# Pipeline Configurator -- Workspace Configuration

## Overview
This workspace includes the **Pipeline Configurator** agent. Use when configuring CI build pipelines with lint, build, test, scan, and package stages.

## Agent Invocation
- Use `@pipeline-configurator` to invoke the agent directly
- Use `/pipeline-configurator.prompt` for guided workflow prompts
- Use `/pipeline-configurator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PIPELINE_CON_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `PIPELINE_CON_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `PIPELINE_CON_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `PIPELINE_CON_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `PIPELINE_CON_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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