# Codebase Scanner -- Workspace Configuration

## Overview
This workspace includes the **Codebase Scanner** agent. Use when scanning codebases to identify files, functions, and modules affected by a proposed feature change.

## Agent Invocation
- Use `@codebase-scanner` to invoke the agent directly
- Use `/codebase-scanner.prompt` for guided workflow prompts
- Use `/codebase-scanner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODEBASE_SCA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CODEBASE_SCA_DRY_RUN` | `false` | Preview changes without executing |
| `CODEBASE_SCA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CODEBASE_SCA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CODEBASE_SCA_NOTIFY` | `true` | Send notifications on completion |

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