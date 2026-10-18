# Progress Tracker -- Workspace Configuration

## Overview
This workspace includes the **Progress Tracker** agent. Use when tracking program milestones, computing RAG status from quantitative data, analyzing schedule variance, or generating burndown/burnup projections.

## Agent Invocation
- Use `@progress-tracker` to invoke the agent directly
- Use `/progress-tracker.prompt` for guided workflow prompts
- Use `/progress-tracker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PROGRESS_TRA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PROGRESS_TRA_DRY_RUN` | `false` | Preview changes without executing |
| `PROGRESS_TRA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PROGRESS_TRA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PROGRESS_TRA_NOTIFY` | `true` | Send notifications on completion |

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