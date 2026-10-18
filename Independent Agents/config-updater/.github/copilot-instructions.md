# Config Updater -- Workspace Configuration

## Overview
This workspace includes the **Config Updater** agent. Use when updating configuration files for new version requirements including env vars, config schemas, and feature flags.

## Agent Invocation
- Use `@config-updater` to invoke the agent directly
- Use `/config-updater.prompt` for guided workflow prompts
- Use `/config-updater-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONFIG_UPDAT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CONFIG_UPDAT_DRY_RUN` | `false` | Preview changes without executing |
| `CONFIG_UPDAT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CONFIG_UPDAT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CONFIG_UPDAT_NOTIFY` | `true` | Send notifications on completion |

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