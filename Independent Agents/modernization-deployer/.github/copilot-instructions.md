# Modernization Deployer -- Workspace Configuration

## Overview
This workspace includes the **Modernization Deployer** agent. Use when deploying modernized applications including infrastructure provisioning, service mesh configuration, CI/CD pipeline setup, and feature flag management.

## Agent Invocation
- Use `@modernization-deployer` to invoke the agent directly
- Use `/modernization-deployer.prompt` for guided workflow prompts
- Use `/modernization-deployer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODERNIZATIO_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `MODERNIZATIO_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `MODERNIZATIO_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `MODERNIZATIO_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `MODERNIZATIO_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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