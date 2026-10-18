# Legacy Deployment Manager -- Workspace Configuration

## Overview
This workspace includes the **Legacy Deployment Manager** agent. Use when managing legacy migration deployment including cutover planning, parallel run coordination, data synchronization, and fallback procedures.

## Agent Invocation
- Use `@legacy-deployment-manager` to invoke the agent directly
- Use `/legacy-deployment-manager.prompt` for guided workflow prompts
- Use `/legacy-deployment-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_DEPLO_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `LEGACY_DEPLO_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `LEGACY_DEPLO_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `LEGACY_DEPLO_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `LEGACY_DEPLO_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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