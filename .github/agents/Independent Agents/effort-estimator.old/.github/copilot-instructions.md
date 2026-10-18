# Effort Estimator -- Workspace Configuration

## Overview
This workspace includes the **Effort Estimator** agent. Use when producing effort estimates with confidence intervals based on scope, complexity, and risk factors.

## Agent Invocation
- Use `@effort-estimator` to invoke the agent directly
- Use `/effort-estimator.prompt` for guided workflow prompts
- Use `/effort-estimator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EFFORT_ESTIM_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EFFORT_ESTIM_DRY_RUN` | `false` | Preview changes without executing |
| `EFFORT_ESTIM_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EFFORT_ESTIM_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EFFORT_ESTIM_NOTIFY` | `true` | Send notifications on completion |

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