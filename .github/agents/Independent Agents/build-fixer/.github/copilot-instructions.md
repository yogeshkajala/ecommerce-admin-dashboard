# Build Fixer -- Workspace Configuration

## Overview
This workspace includes the **Build Fixer** agent. Fix build and compilation errors caused by version upgrades.

## Agent Invocation
- Use `@build-fixer` to invoke the agent directly
- Use `/build-fixer.prompt` for guided workflow prompts
- Use `/build-fixer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUILD_FIXER_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `BUILD_FIXER_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `BUILD_FIXER_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `BUILD_FIXER_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `BUILD_FIXER_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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