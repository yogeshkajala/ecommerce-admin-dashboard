# Sixr Mapper -- Workspace Configuration

## Overview
This workspace includes the **Sixr Mapper** agent. Use when classifying applications using Gartner 6Rs (Rehost, Replatform, Refactor, Repurchase, Retire, Retain) with documented decision rationale.

## Agent Invocation
- Use `@sixr-mapper` to invoke the agent directly
- Use `/sixr-mapper.prompt` for guided workflow prompts
- Use `/sixr-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SIXR_MAPPER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SIXR_MAPPER_DRY_RUN` | `false` | Preview changes without executing |
| `SIXR_MAPPER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SIXR_MAPPER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SIXR_MAPPER_NOTIFY` | `true` | Send notifications on completion |

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