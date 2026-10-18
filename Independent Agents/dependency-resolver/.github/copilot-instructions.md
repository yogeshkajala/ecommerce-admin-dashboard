# Dependency Resolver -- Workspace Configuration

## Overview
This workspace includes the **Dependency Resolver** agent. Use when resolving and locking dependencies with integrity verification and CVE scanning.

## Agent Invocation
- Use `@dependency-resolver` to invoke the agent directly
- Use `/dependency-resolver.prompt` for guided workflow prompts
- Use `/dependency-resolver-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_R_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DEPENDENCY_R_DRY_RUN` | `false` | Preview changes without executing |
| `DEPENDENCY_R_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DEPENDENCY_R_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DEPENDENCY_R_NOTIFY` | `true` | Send notifications on completion |

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