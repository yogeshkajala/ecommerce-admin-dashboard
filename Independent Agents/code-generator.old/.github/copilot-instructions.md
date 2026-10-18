# Code Generator -- Workspace Configuration

## Overview
This workspace includes the **Code Generator** agent. Use when generating production-quality code following project conventions, architecture specifications, and SOLID principles.

## Agent Invocation
- Use `@code-generator` to invoke the agent directly
- Use `/code-generator.prompt` for guided workflow prompts
- Use `/code-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_GENERAT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CODE_GENERAT_DRY_RUN` | `false` | Preview changes without executing |
| `CODE_GENERAT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CODE_GENERAT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CODE_GENERAT_NOTIFY` | `true` | Send notifications on completion |

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