# Dependency Tracker -- Workspace Configuration

## Overview
This workspace includes the **Dependency Tracker** agent. Use when tracking dependencies between stories, teams, and external systems.

## Agent Invocation
- Use `@dependency-tracker` to invoke the agent directly
- Use `/dependency-tracker.prompt` for guided workflow prompts
- Use `/dependency-tracker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_T_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DEPENDENCY_T_DRY_RUN` | `false` | Preview changes without executing |
| `DEPENDENCY_T_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DEPENDENCY_T_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DEPENDENCY_T_NOTIFY` | `true` | Send notifications on completion |

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