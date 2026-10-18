# Team Allocator -- Workspace Configuration

## Overview
This workspace includes the **Team Allocator** agent. Use when allocating team members to project roles, managing workload distribution, and resolving allocation conflicts.

## Agent Invocation
- Use `@team-allocator` to invoke the agent directly
- Use `/team-allocator.prompt` for guided workflow prompts
- Use `/team-allocator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEAM_ALLOCAT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `TEAM_ALLOCAT_DRY_RUN` | `false` | Preview changes without executing |
| `TEAM_ALLOCAT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `TEAM_ALLOCAT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `TEAM_ALLOCAT_NOTIFY` | `true` | Send notifications on completion |

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