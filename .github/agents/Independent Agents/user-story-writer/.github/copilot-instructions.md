# User Story Writer -- Workspace Configuration

## Overview
This workspace includes the **User Story Writer** agent. Use when writing user stories from feature briefs, stakeholder input, and product requirements.

## Agent Invocation
- Use `@user-story-writer` to invoke the agent directly
- Use `/user-story-writer.prompt` for guided workflow prompts
- Use `/user-story-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `USER_STORY_W_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `USER_STORY_W_DRY_RUN` | `false` | Preview changes without executing |
| `USER_STORY_W_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `USER_STORY_W_TIMEOUT` | `300` | Maximum execution time in seconds |
| `USER_STORY_W_NOTIFY` | `true` | Send notifications on completion |

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