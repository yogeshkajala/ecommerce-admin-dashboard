# Code Developer -- Workspace Configuration

## Overview
This workspace includes the **Code Developer** agent. Use when generating production code, conducting code reviews, running static analysis, or optimizing code performance.

## Agent Invocation
- Use `@code-developer` to invoke the agent directly
- Use `/code-developer.prompt` for guided workflow prompts
- Use `/code-developer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_DEVELOP_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CODE_DEVELOP_DRY_RUN` | `false` | Preview changes without executing |
| `CODE_DEVELOP_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CODE_DEVELOP_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CODE_DEVELOP_NOTIFY` | `true` | Send notifications on completion |

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