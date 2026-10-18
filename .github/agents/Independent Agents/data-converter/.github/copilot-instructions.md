# Data Converter -- Workspace Configuration

## Overview
This workspace includes the **Data Converter** agent. Use when implementing data migration scripts with validation, rollback, and checksum verification.

## Agent Invocation
- Use `@data-converter` to invoke the agent directly
- Use `/data-converter.prompt` for guided workflow prompts
- Use `/data-converter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_CONVERT_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `DATA_CONVERT_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `DATA_CONVERT_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `DATA_CONVERT_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `DATA_CONVERT_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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