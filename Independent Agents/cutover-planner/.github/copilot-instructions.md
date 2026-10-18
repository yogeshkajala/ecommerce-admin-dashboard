# Cutover Planner -- Workspace Configuration

## Overview
This workspace includes the **Cutover Planner** agent. Use when creating detailed cutover plans for legacy migration including timelines, checkpoints, task sequences, and rollback decision points.

## Agent Invocation
- Use `@cutover-planner` to invoke the agent directly
- Use `/cutover-planner.prompt` for guided workflow prompts
- Use `/cutover-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CUTOVER_PLAN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `CUTOVER_PLAN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `CUTOVER_PLAN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `CUTOVER_PLAN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `CUTOVER_PLAN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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