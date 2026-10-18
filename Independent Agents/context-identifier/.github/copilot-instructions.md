# Context Identifier -- Workspace Configuration

## Overview
This workspace includes the **Context Identifier** agent. Identify bounded contexts using domain-driven design strategic patterns.

## Agent Invocation
- Use `@context-identifier` to invoke the agent directly
- Use `/context-identifier.prompt` for guided workflow prompts
- Use `/context-identifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTEXT_IDEN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CONTEXT_IDEN_DRY_RUN` | `false` | Preview changes without executing |
| `CONTEXT_IDEN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CONTEXT_IDEN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CONTEXT_IDEN_NOTIFY` | `true` | Send notifications on completion |

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