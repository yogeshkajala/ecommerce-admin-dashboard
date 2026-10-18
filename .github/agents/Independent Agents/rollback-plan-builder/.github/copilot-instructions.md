# Rollback Plan Builder -- Workspace Configuration

## Overview
This workspace includes the **Rollback Plan Builder** agent. Use when building rollback procedures for each upgrade step to ensure safe recovery from failures.

## Agent Invocation
- Use `@rollback-plan-builder` to invoke the agent directly
- Use `/rollback-plan-builder.prompt` for guided workflow prompts
- Use `/rollback-plan-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROLLBACK_PLA_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `ROLLBACK_PLA_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `ROLLBACK_PLA_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `ROLLBACK_PLA_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `ROLLBACK_PLA_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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