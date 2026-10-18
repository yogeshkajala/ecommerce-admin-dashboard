# Feature Architect -- Workspace Configuration

## Overview
This workspace includes the **Feature Architect** agent. Use when designing feature component architecture within existing systems, ensuring consistency with established patterns.

## Agent Invocation
- Use `@feature-architect` to invoke the agent directly
- Use `/feature-architect.prompt` for guided workflow prompts
- Use `/feature-architect-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_ARCH_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FEATURE_ARCH_DRY_RUN` | `false` | Preview changes without executing |
| `FEATURE_ARCH_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FEATURE_ARCH_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FEATURE_ARCH_NOTIFY` | `true` | Send notifications on completion |

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