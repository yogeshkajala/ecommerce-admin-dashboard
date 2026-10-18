# Feature Engineer -- Workspace Configuration

## Overview
This workspace includes the **Feature Engineer** agent. Use when designing ML features, computing feature transformations, managing feature store, or validating feature distributions.

## Agent Invocation
- Use `@feature-engineer` to invoke the agent directly
- Use `/feature-engineer.prompt` for guided workflow prompts
- Use `/feature-engineer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_ENGI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FEATURE_ENGI_DRY_RUN` | `false` | Preview changes without executing |
| `FEATURE_ENGI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FEATURE_ENGI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FEATURE_ENGI_NOTIFY` | `true` | Send notifications on completion |

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