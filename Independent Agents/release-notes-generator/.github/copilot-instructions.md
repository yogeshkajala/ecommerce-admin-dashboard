# Release Notes Generator -- Workspace Configuration

## Overview
This workspace includes the **Release Notes Generator** agent. Use when generating release notes from changelog including features, fixes, breaking changes, and known issues.

## Agent Invocation
- Use `@release-notes-generator` to invoke the agent directly
- Use `/release-notes-generator.prompt` for guided workflow prompts
- Use `/release-notes-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RELEASE_NOTE_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `RELEASE_NOTE_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `RELEASE_NOTE_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `RELEASE_NOTE_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `RELEASE_NOTE_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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