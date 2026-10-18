# Developer Assistant -- Workspace Configuration

## Overview
This workspace includes the **Developer Assistant** agent. Use when navigating codebases, debugging issues, onboarding to new projects, or finding technical knowledge and documentation.

## Agent Invocation
- Use `@developer-assistant` to invoke the agent directly
- Use `/developer-assistant.prompt` for guided workflow prompts
- Use `/developer-assistant-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEVELOPER_AS_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DEVELOPER_AS_DRY_RUN` | `false` | Preview changes without executing |
| `DEVELOPER_AS_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DEVELOPER_AS_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DEVELOPER_AS_NOTIFY` | `true` | Send notifications on completion |

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