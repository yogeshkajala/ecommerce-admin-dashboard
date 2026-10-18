# Onboarding Guide -- Workspace Configuration

## Overview
This workspace includes the **Onboarding Guide** agent. Use when onboarding new developers to a project, explaining setup procedures, or documenting project conventions.

## Agent Invocation
- Use `@onboarding-guide` to invoke the agent directly
- Use `/onboarding-guide.prompt` for guided workflow prompts
- Use `/onboarding-guide-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ONBOARDING_G_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `ONBOARDING_G_DRY_RUN` | `false` | Preview changes without executing |
| `ONBOARDING_G_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `ONBOARDING_G_TIMEOUT` | `300` | Maximum execution time in seconds |
| `ONBOARDING_G_NOTIFY` | `true` | Send notifications on completion |

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