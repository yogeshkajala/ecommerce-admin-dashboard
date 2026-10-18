# Retrospective Facilitator -- Workspace Configuration

## Overview
This workspace includes the **Retrospective Facilitator** agent. Use when facilitating sprint retrospectives with structured what-went-well, what-to-improve, and action item tracking.

## Agent Invocation
- Use `@retrospective-facilitator` to invoke the agent directly
- Use `/retrospective-facilitator.prompt` for guided workflow prompts
- Use `/retrospective-facilitator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RETROSPECTIV_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `RETROSPECTIV_DRY_RUN` | `false` | Preview changes without executing |
| `RETROSPECTIV_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `RETROSPECTIV_TIMEOUT` | `300` | Maximum execution time in seconds |
| `RETROSPECTIV_NOTIFY` | `true` | Send notifications on completion |

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