# Deprecation Fixer -- Workspace Configuration

## Overview
This workspace includes the **Deprecation Fixer** agent. Use when fixing deprecated API usage, replacing removed APIs with recommended alternatives.

## Agent Invocation
- Use `@deprecation-fixer` to invoke the agent directly
- Use `/deprecation-fixer.prompt` for guided workflow prompts
- Use `/deprecation-fixer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPRECATION__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DEPRECATION__DRY_RUN` | `false` | Preview changes without executing |
| `DEPRECATION__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DEPRECATION__TIMEOUT` | `300` | Maximum execution time in seconds |
| `DEPRECATION__NOTIFY` | `true` | Send notifications on completion |

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