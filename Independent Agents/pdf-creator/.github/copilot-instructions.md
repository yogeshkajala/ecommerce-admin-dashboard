# Pdf Creator -- Workspace Configuration

## Overview
This workspace includes the **Pdf Creator** agent. Use when generating PDF documents from HTML or Markdown content using WeasyPrint, wkhtmltopdf, or Markdown-to-PDF conversion with professional formatting.

## Agent Invocation
- Use `@pdf-creator` to invoke the agent directly
- Use `/pdf-creator.prompt` for guided workflow prompts
- Use `/pdf-creator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PDF_CREATOR_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PDF_CREATOR_DRY_RUN` | `false` | Preview changes without executing |
| `PDF_CREATOR_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PDF_CREATOR_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PDF_CREATOR_NOTIFY` | `true` | Send notifications on completion |

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