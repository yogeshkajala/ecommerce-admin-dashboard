# Build Manager -- Workspace Configuration

## Overview
This workspace includes the **Build Manager** agent. Use when managing build pipelines, dependency resolution, artifact creation, and version management.

## Agent Invocation
- Use `@build-manager` to invoke the agent directly
- Use `/build-manager.prompt` for guided workflow prompts
- Use `/build-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUILD_MANAGE_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `BUILD_MANAGE_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `BUILD_MANAGE_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `BUILD_MANAGE_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `BUILD_MANAGE_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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