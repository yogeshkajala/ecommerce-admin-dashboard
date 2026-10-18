# Azure Deployer -- Workspace Configuration

## Overview
This workspace includes the **Azure Deployer** agent. Deploy to Azure: App Service, AKS, Functions, Blob Storage, and supporting services.

## Agent Invocation
- Use `@azure-deployer` to invoke the agent directly
- Use `/azure-deployer.prompt` for guided workflow prompts
- Use `/azure-deployer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AZURE_DEPLOY_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `AZURE_DEPLOY_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `AZURE_DEPLOY_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `AZURE_DEPLOY_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `AZURE_DEPLOY_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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