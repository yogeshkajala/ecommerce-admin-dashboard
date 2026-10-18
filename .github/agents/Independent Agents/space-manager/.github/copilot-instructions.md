# Space Manager -- Workspace Configuration

## Overview
This workspace includes the **Space Manager** agent. Use when managing Confluence spaces, setting permissions, organizing page hierarchies, or archiving content.

## Agent Invocation
- Use `@space-manager` to invoke the agent directly
- Use `/space-manager.prompt` for guided workflow prompts
- Use `/space-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SPACE_MANAGE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SPACE_MANAGE_DRY_RUN` | `false` | Preview changes without executing |
| `SPACE_MANAGE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SPACE_MANAGE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SPACE_MANAGE_NOTIFY` | `true` | Send notifications on completion |

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