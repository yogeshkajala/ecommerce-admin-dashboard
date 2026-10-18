# Environment Manager -- Workspace Configuration

## Overview
This workspace includes the **Environment Manager** agent. Use when provisioning and managing development, staging, and production environments including configuration, access control, and parity enforcement.

## Agent Invocation
- Use `@environment-manager` to invoke the agent directly
- Use `/environment-manager.prompt` for guided workflow prompts
- Use `/environment-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ENVIRONMENT__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `ENVIRONMENT__DRY_RUN` | `false` | Preview changes without executing |
| `ENVIRONMENT__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `ENVIRONMENT__TIMEOUT` | `300` | Maximum execution time in seconds |
| `ENVIRONMENT__NOTIFY` | `true` | Send notifications on completion |

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