# Content Syncer -- Workspace Configuration

## Overview
This workspace includes the **Content Syncer** agent. Use when syncing documentation from code repositories to Confluence, mirroring README files, or keeping wiki in sync with source control.

## Agent Invocation
- Use `@content-syncer` to invoke the agent directly
- Use `/content-syncer.prompt` for guided workflow prompts
- Use `/content-syncer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTENT_SYNC_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CONTENT_SYNC_DRY_RUN` | `false` | Preview changes without executing |
| `CONTENT_SYNC_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CONTENT_SYNC_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CONTENT_SYNC_NOTIFY` | `true` | Send notifications on completion |

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