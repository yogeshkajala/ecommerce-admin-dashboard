# Code Navigator -- Workspace Configuration

## Overview
This workspace includes the **Code Navigator** agent. Use when finding code implementations, tracing call paths, exploring architecture, or locating configuration files.

## Agent Invocation
- Use `@code-navigator` to invoke the agent directly
- Use `/code-navigator.prompt` for guided workflow prompts
- Use `/code-navigator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_NAVIGAT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CODE_NAVIGAT_DRY_RUN` | `false` | Preview changes without executing |
| `CODE_NAVIGAT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CODE_NAVIGAT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CODE_NAVIGAT_NOTIFY` | `true` | Send notifications on completion |

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