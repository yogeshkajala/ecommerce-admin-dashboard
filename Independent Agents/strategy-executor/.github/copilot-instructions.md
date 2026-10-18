# Strategy Executor -- Workspace Configuration

## Overview
This workspace includes the **Strategy Executor** agent. Use when executing deployment strategies: canary (progressive %), blue-green (swap), rolling (in-place), recreate.

## Agent Invocation
- Use `@strategy-executor` to invoke the agent directly
- Use `/strategy-executor.prompt` for guided workflow prompts
- Use `/strategy-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STRATEGY_EXE_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `STRATEGY_EXE_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `STRATEGY_EXE_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `STRATEGY_EXE_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `STRATEGY_EXE_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

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