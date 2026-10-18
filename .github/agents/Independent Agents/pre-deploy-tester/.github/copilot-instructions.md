# Pre Deploy Tester -- Workspace Configuration

## Overview
This workspace includes the **Pre Deploy Tester** agent. Use when running pre-deployment tests including smoke tests, integration tests, security scans, and configuration validation before deployment execution.

## Agent Invocation
- Use `@pre-deploy-tester` to invoke the agent directly
- Use `/pre-deploy-tester.prompt` for guided workflow prompts
- Use `/pre-deploy-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PRE_DEPLOY_T_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `PRE_DEPLOY_T_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `PRE_DEPLOY_T_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `PRE_DEPLOY_T_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `PRE_DEPLOY_T_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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