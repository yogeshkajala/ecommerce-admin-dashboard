# Microservice Architect -- Workspace Configuration

## Overview
This workspace includes the **Microservice Architect** agent. Use when designing microservice boundaries, data ownership, event contracts, and API gateway patterns.

## Agent Invocation
- Use `@microservice-architect` to invoke the agent directly
- Use `/microservice-architect.prompt` for guided workflow prompts
- Use `/microservice-architect-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MICROSERVICE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MICROSERVICE_DRY_RUN` | `false` | Preview changes without executing |
| `MICROSERVICE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MICROSERVICE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MICROSERVICE_NOTIFY` | `true` | Send notifications on completion |

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