# Relationship Mapper -- Workspace Configuration

## Overview
This workspace includes the **Relationship Mapper** agent. Map and maintain relationships between entities in the knowledge graph including dependencies, ownership, and operational connections.

## Agent Invocation
- Use `@relationship-mapper` to invoke the agent directly
- Use `/relationship-mapper.prompt` for guided workflow prompts
- Use `/relationship-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RELATIONSHIP_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `RELATIONSHIP_DRY_RUN` | `false` | Preview changes without executing |
| `RELATIONSHIP_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `RELATIONSHIP_TIMEOUT` | `300` | Maximum execution time in seconds |
| `RELATIONSHIP_NOTIFY` | `true` | Send notifications on completion |

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