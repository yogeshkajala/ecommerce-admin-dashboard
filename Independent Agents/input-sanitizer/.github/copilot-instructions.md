# Input Sanitizer -- Workspace Configuration

## Overview
This workspace includes the **Input Sanitizer** agent. Use when sanitizing user inputs, normalizing text encoding, stripping dangerous characters, enforcing input length limits, or decontaminating tool outputs before agent processing.

## Agent Invocation
- Use `@input-sanitizer` to invoke the agent directly
- Use `/input-sanitizer.prompt` for guided workflow prompts
- Use `/input-sanitizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INPUT_SANITI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `INPUT_SANITI_DRY_RUN` | `false` | Preview changes without executing |
| `INPUT_SANITI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `INPUT_SANITI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `INPUT_SANITI_NOTIFY` | `true` | Send notifications on completion |

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