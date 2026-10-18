# Knowledge Updater -- Workspace Configuration

## Overview
This workspace includes the **Knowledge Updater** agent. Use when ingesting new knowledge, updating existing articles, detecting stale content, or archiving retired knowledge.

## Agent Invocation
- Use `@knowledge-updater` to invoke the agent directly
- Use `/knowledge-updater.prompt` for guided workflow prompts
- Use `/knowledge-updater-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `KNOWLEDGE_UP_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `KNOWLEDGE_UP_DRY_RUN` | `false` | Preview changes without executing |
| `KNOWLEDGE_UP_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `KNOWLEDGE_UP_TIMEOUT` | `300` | Maximum execution time in seconds |
| `KNOWLEDGE_UP_NOTIFY` | `true` | Send notifications on completion |

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