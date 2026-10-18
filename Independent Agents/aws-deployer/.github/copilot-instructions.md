# Aws Deployer -- Workspace Configuration

## Overview
This workspace includes the **Aws Deployer** agent. Deploy to AWS: ECS, EKS, Lambda, S3, CloudFront, RDS, and supporting services.

## Agent Invocation
- Use `@aws-deployer` to invoke the agent directly
- Use `/aws-deployer.prompt` for guided workflow prompts
- Use `/aws-deployer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AWS_DEPLOYER_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `AWS_DEPLOYER_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `AWS_DEPLOYER_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `AWS_DEPLOYER_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `AWS_DEPLOYER_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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