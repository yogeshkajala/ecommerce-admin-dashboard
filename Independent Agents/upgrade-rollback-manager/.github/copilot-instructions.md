# Upgrade Rollback Manager -- Workspace Configuration

## Overview
This workspace includes the **Upgrade Rollback Manager** agent. Use when managing upgrade rollback operations -- snapshot management, state rollback, traffic rerouting, and data recovery.

## Agent Invocation
- Use `@upgrade-rollback-manager` to invoke the agent directly
- Use `/upgrade-rollback-manager.prompt` for guided workflow prompts
- Use `/upgrade-rollback-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UPGRADE_ROLL_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `UPGRADE_ROLL_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `UPGRADE_ROLL_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `UPGRADE_ROLL_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `UPGRADE_ROLL_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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