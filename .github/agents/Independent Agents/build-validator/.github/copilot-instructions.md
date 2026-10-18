# Build Validator -- Workspace Configuration

## Overview
This workspace includes the **Build Validator** agent. Use when verifying that upgraded code builds successfully with zero errors and minimal new warnings.

## Agent Invocation
- Use `@build-validator` to invoke the agent directly
- Use `/build-validator.prompt` for guided workflow prompts
- Use `/build-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUILD_VALIDA_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `BUILD_VALIDA_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `BUILD_VALIDA_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `BUILD_VALIDA_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `BUILD_VALIDA_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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