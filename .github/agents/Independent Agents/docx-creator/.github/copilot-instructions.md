# Docx Creator -- Workspace Configuration

## Overview
This workspace includes the **Docx Creator** agent. Use when generating Word (DOCX) documents with styled headings, tables, TOC, headers/footers, and corporate branding using python-docx.

## Agent Invocation
- Use `@docx-creator` to invoke the agent directly
- Use `/docx-creator.prompt` for guided workflow prompts
- Use `/docx-creator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DOCX_CREATOR_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DOCX_CREATOR_DRY_RUN` | `false` | Preview changes without executing |
| `DOCX_CREATOR_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DOCX_CREATOR_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DOCX_CREATOR_NOTIFY` | `true` | Send notifications on completion |

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