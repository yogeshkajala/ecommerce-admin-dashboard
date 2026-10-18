# Confluence Publisher -- Workspace Configuration

## Overview
This workspace includes the **Confluence Publisher** agent. Use when creating Confluence pages, managing wiki spaces, publishing documentation, syncing content from repositories, or rendering templates. Covers full Confluence wiki lifecycle.

## Agent Invocation
- Use `@confluence-publisher` to invoke the agent directly
- Use `/confluence-publisher.prompt` for guided workflow prompts
- Use `/confluence-publisher-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONFLUENCE_P_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CONFLUENCE_P_DRY_RUN` | `false` | Preview changes without executing |
| `CONFLUENCE_P_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CONFLUENCE_P_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CONFLUENCE_P_NOTIFY` | `true` | Send notifications on completion |

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