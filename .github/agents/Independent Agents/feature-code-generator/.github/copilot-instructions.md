# Feature Code Generator -- Workspace Configuration

## Overview
This workspace includes the **Feature Code Generator** agent. Use when generating feature code that follows existing codebase conventions, extends established patterns, and includes proper error handling.

## Agent Invocation
- Use `@feature-code-generator` to invoke the agent directly
- Use `/feature-code-generator.prompt` for guided workflow prompts
- Use `/feature-code-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_CODE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FEATURE_CODE_DRY_RUN` | `false` | Preview changes without executing |
| `FEATURE_CODE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FEATURE_CODE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FEATURE_CODE_NOTIFY` | `true` | Send notifications on completion |

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