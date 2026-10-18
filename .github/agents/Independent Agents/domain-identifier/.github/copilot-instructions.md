# Domain Identifier -- Workspace Configuration

## Overview
This workspace includes the **Domain Identifier** agent. Use when identifying bounded contexts and domain boundaries in monolithic applications using DDD principles.

## Agent Invocation
- Use `@domain-identifier` to invoke the agent directly
- Use `/domain-identifier.prompt` for guided workflow prompts
- Use `/domain-identifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DOMAIN_IDENT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DOMAIN_IDENT_DRY_RUN` | `false` | Preview changes without executing |
| `DOMAIN_IDENT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DOMAIN_IDENT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DOMAIN_IDENT_NOTIFY` | `true` | Send notifications on completion |

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