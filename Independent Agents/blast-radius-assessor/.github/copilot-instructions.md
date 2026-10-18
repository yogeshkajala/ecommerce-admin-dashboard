# Blast Radius Assessor -- Workspace Configuration

## Overview
This workspace includes the **Blast Radius Assessor** agent. Determine blast radius: affected services, components, users, and data.

## Agent Invocation
- Use `@blast-radius-assessor` to invoke the agent directly
- Use `/blast-radius-assessor.prompt` for guided workflow prompts
- Use `/blast-radius-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BLAST_RADIUS_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `BLAST_RADIUS_DRY_RUN` | `false` | Preview changes without executing |
| `BLAST_RADIUS_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `BLAST_RADIUS_TIMEOUT` | `300` | Maximum execution time in seconds |
| `BLAST_RADIUS_NOTIFY` | `true` | Send notifications on completion |

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