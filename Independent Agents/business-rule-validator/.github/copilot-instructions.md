# Business Rule Validator -- Workspace Configuration

## Overview
This workspace includes the **Business Rule Validator** agent. Use when verifying every extracted business rule is correctly implemented in the modern system.

## Agent Invocation
- Use `@business-rule-validator` to invoke the agent directly
- Use `/business-rule-validator.prompt` for guided workflow prompts
- Use `/business-rule-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUSINESS_RUL_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `BUSINESS_RUL_DRY_RUN` | `false` | Preview changes without executing |
| `BUSINESS_RUL_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `BUSINESS_RUL_TIMEOUT` | `300` | Maximum execution time in seconds |
| `BUSINESS_RUL_NOTIFY` | `true` | Send notifications on completion |

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