# Artifact Manager -- Workspace Configuration

## Overview
This workspace includes the **Artifact Manager** agent. Use when managing build artifacts including packaging, signing, SBOM generation, and registry storage.

## Agent Invocation
- Use `@artifact-manager` to invoke the agent directly
- Use `/artifact-manager.prompt` for guided workflow prompts
- Use `/artifact-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ARTIFACT_MAN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `ARTIFACT_MAN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `ARTIFACT_MAN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `ARTIFACT_MAN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `ARTIFACT_MAN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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