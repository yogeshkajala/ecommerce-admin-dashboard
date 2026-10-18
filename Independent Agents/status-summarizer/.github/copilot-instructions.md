# Status Summarizer -- Workspace Configuration

## Overview
This workspace includes the **Status Summarizer** agent. Use when generating executive status narratives, summarizing weekly/monthly progress, creating highlights and lowlights, or distilling complex project data for leadership.

## Agent Invocation
- Use `@status-summarizer` to invoke the agent directly
- Use `/status-summarizer.prompt` for guided workflow prompts
- Use `/status-summarizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STATUS_SUMMA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `STATUS_SUMMA_DRY_RUN` | `false` | Preview changes without executing |
| `STATUS_SUMMA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `STATUS_SUMMA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `STATUS_SUMMA_NOTIFY` | `true` | Send notifications on completion |

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