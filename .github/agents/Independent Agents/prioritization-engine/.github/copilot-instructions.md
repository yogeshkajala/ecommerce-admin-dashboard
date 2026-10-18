# Prioritization Engine -- Workspace Configuration

## Overview
This workspace includes the **Prioritization Engine** agent. Use when scoring and prioritizing features using RICE, MoSCoW, or weighted scoring frameworks.

## Agent Invocation
- Use `@prioritization-engine` to invoke the agent directly
- Use `/prioritization-engine.prompt` for guided workflow prompts
- Use `/prioritization-engine-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PRIORITIZATI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PRIORITIZATI_DRY_RUN` | `false` | Preview changes without executing |
| `PRIORITIZATI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PRIORITIZATI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PRIORITIZATI_NOTIFY` | `true` | Send notifications on completion |

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