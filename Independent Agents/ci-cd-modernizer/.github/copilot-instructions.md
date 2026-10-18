# Ci Cd Modernizer -- Workspace Configuration

## Overview
This workspace includes the **Ci Cd Modernizer** agent. Use when modernizing CI/CD pipelines for cloud-native deployment including container builds, registry push, and Kubernetes deployment.

## Agent Invocation
- Use `@ci-cd-modernizer` to invoke the agent directly
- Use `/ci-cd-modernizer.prompt` for guided workflow prompts
- Use `/ci-cd-modernizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CI_CD_MODERN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `CI_CD_MODERN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `CI_CD_MODERN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `CI_CD_MODERN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `CI_CD_MODERN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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