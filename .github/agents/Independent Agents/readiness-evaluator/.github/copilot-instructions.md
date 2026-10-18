# Readiness Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Readiness Evaluator** agent. Evaluate application cloud readiness using 6R framework.

## Agent Invocation
- Use `@readiness-evaluator` to invoke the agent directly
- Use `/readiness-evaluator.prompt` for guided workflow prompts
- Use `/readiness-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `READINESS_EV_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `READINESS_EV_DRY_RUN` | `false` | Preview changes without executing |
| `READINESS_EV_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `READINESS_EV_TIMEOUT` | `300` | Maximum execution time in seconds |
| `READINESS_EV_NOTIFY` | `true` | Send notifications on completion |

## Key Conventions
- Follow established coding standards and best practices
- Use the agent for domain-specific tasks within its scope
- Provide clear, specific context when invoking the agent
- Review agent outputs before applying changes
- Use dry-run mode for previewing changes

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations