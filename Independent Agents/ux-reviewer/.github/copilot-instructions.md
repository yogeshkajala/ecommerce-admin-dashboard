# Ux Reviewer -- Workspace Configuration

## Overview
This workspace includes the **Ux Reviewer** agent. Use when reviewing UX changes for consistency, accessibility (WCAG 2.1), and alignment with existing design patterns.

## Agent Invocation
- Use `@ux-reviewer` to invoke the agent directly
- Use `/ux-reviewer.prompt` for guided workflow prompts
- Use `/ux-reviewer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UX_REVIEWER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `UX_REVIEWER_DRY_RUN` | `false` | Preview changes without executing |
| `UX_REVIEWER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `UX_REVIEWER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `UX_REVIEWER_NOTIFY` | `true` | Send notifications on completion |

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