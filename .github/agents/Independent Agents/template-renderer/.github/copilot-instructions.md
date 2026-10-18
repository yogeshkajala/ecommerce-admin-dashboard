# Template Renderer -- Workspace Configuration

## Overview
This workspace includes the **Template Renderer** agent. Use when rendering content using Confluence templates, converting markdown to storage format, or formatting documents for wiki publishing.

## Agent Invocation
- Use `@template-renderer` to invoke the agent directly
- Use `/template-renderer.prompt` for guided workflow prompts
- Use `/template-renderer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEMPLATE_REN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `TEMPLATE_REN_DRY_RUN` | `false` | Preview changes without executing |
| `TEMPLATE_REN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `TEMPLATE_REN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `TEMPLATE_REN_NOTIFY` | `true` | Send notifications on completion |

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