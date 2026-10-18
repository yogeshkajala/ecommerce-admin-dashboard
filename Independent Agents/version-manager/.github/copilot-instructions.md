# Version Manager -- Workspace Configuration

## Overview
This workspace includes the **Version Manager** agent. Use when managing version numbers following Semantic Versioning 2.0, generating changelogs, and tagging releases.

## Agent Invocation
- Use `@version-manager` to invoke the agent directly
- Use `/version-manager.prompt` for guided workflow prompts
- Use `/version-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `VERSION_MANA_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `VERSION_MANA_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `VERSION_MANA_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `VERSION_MANA_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `VERSION_MANA_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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