# Work Item Syncer -- Workspace Configuration

## Overview
This workspace includes the **Work Item Syncer** agent. Use when creating Jira issues, syncing work items from requirements documents, or performing bulk ticket operations with ADF-formatted content.

## Agent Invocation
- Use `@work-item-syncer` to invoke the agent directly
- Use `/work-item-syncer.prompt` for guided workflow prompts
- Use `/work-item-syncer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `WORK_ITEM_SY_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `WORK_ITEM_SY_DRY_RUN` | `false` | Preview changes without executing |
| `WORK_ITEM_SY_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `WORK_ITEM_SY_TIMEOUT` | `300` | Maximum execution time in seconds |
| `WORK_ITEM_SY_NOTIFY` | `true` | Send notifications on completion |

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