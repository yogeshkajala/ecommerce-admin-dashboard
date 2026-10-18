# Quality Gate Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Quality Gate Evaluator** agent. Use when evaluating quality gate criteria and producing go/no-go release recommendation with supporting evidence.

## Agent Invocation
- Use `@quality-gate-evaluator` to invoke the agent directly
- Use `/quality-gate-evaluator.prompt` for guided workflow prompts
- Use `/quality-gate-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `QUALITY_GATE_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `QUALITY_GATE_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `QUALITY_GATE_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `QUALITY_GATE_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `QUALITY_GATE_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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