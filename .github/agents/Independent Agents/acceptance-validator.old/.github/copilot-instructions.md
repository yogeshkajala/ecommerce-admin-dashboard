# Acceptance Validator -- Workspace Configuration

## Overview
This workspace includes the **Acceptance Validator** agent. Use when verifying that implemented features meet all acceptance criteria defined during requirements.

## Agent Invocation
- Use `@acceptance-validator` to invoke the agent directly
- Use `/acceptance-validator.prompt` for guided workflow prompts
- Use `/acceptance-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ACCEPTANCE_V_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `ACCEPTANCE_V_DRY_RUN` | `false` | Preview changes without executing |
| `ACCEPTANCE_V_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `ACCEPTANCE_V_TIMEOUT` | `300` | Maximum execution time in seconds |
| `ACCEPTANCE_V_NOTIFY` | `true` | Send notifications on completion |

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