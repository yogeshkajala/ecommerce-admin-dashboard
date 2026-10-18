# Ux Designer -- Workspace Configuration

## Overview
This workspace includes the **Ux Designer** agent. Design UX/UI: user flows, wireframes, component specifications, and accessibility guidelines.

## Agent Invocation
- Use `@ux-designer` to invoke the agent directly
- Use `/ux-designer.prompt` for guided workflow prompts
- Use `/ux-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UX_DESIGNER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `UX_DESIGNER_DRY_RUN` | `false` | Preview changes without executing |
| `UX_DESIGNER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `UX_DESIGNER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `UX_DESIGNER_NOTIFY` | `true` | Send notifications on completion |

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