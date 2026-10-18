# Ml Pipeline Manager -- Workspace Configuration

## Overview
This workspace includes the **Ml Pipeline Manager** agent. Use when managing ML pipelines, checking data quality, engineering features, training models, or monitoring model drift in production.

## Agent Invocation
- Use `@ml-pipeline-manager` to invoke the agent directly
- Use `/ml-pipeline-manager.prompt` for guided workflow prompts
- Use `/ml-pipeline-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ML_PIPELINE__STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `ML_PIPELINE__HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `ML_PIPELINE__ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `ML_PIPELINE__APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `ML_PIPELINE__NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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