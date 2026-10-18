# Event Contract Designer -- Workspace Configuration

## Overview
This workspace includes the **Event Contract Designer** agent. Use when designing event-driven contracts between microservices with schema versioning and backward compatibility.

## Agent Invocation
- Use `@event-contract-designer` to invoke the agent directly
- Use `/event-contract-designer.prompt` for guided workflow prompts
- Use `/event-contract-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EVENT_CONTRA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EVENT_CONTRA_DRY_RUN` | `false` | Preview changes without executing |
| `EVENT_CONTRA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EVENT_CONTRA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EVENT_CONTRA_NOTIFY` | `true` | Send notifications on completion |

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