# Breaking Change Detector -- Workspace Configuration

## Overview
This workspace includes the **Breaking Change Detector** agent. Detect breaking changes from changelogs, release notes, and API diffs.

## Agent Invocation
- Use `@breaking-change-detector` to invoke the agent directly
- Use `/breaking-change-detector.prompt` for guided workflow prompts
- Use `/breaking-change-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BREAKING_CHA_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `BREAKING_CHA_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `BREAKING_CHA_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `BREAKING_CHA_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `BREAKING_CHA_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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