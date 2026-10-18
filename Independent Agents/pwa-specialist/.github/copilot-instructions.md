# Pwa Specialist -- Workspace Configuration

## Overview
This workspace includes the **Pwa Specialist** agent. Expert PWA development: service workers, offline-first caching, Web App manifest, push notifications, and installability.

## Agent Invocation
- Use `@pwa-specialist` to invoke the agent directly
- Use `/pwa-specialist.prompt` for guided workflow prompts
- Use `/pwa-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PWA_SPECIALI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PWA_SPECIALI_DRY_RUN` | `false` | Preview changes without executing |
| `PWA_SPECIALI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PWA_SPECIALI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PWA_SPECIALI_NOTIFY` | `true` | Send notifications on completion |

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