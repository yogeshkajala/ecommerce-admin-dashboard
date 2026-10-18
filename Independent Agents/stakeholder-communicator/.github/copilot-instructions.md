# Stakeholder Communicator -- Workspace Configuration

## Overview
This workspace includes the **Stakeholder Communicator** agent. Use when crafting audience-tailored stakeholder communications, escalation emails, steering committee briefings, or team newsletters for various leadership levels.

## Agent Invocation
- Use `@stakeholder-communicator` to invoke the agent directly
- Use `/stakeholder-communicator.prompt` for guided workflow prompts
- Use `/stakeholder-communicator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STAKEHOLDER__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `STAKEHOLDER__DRY_RUN` | `false` | Preview changes without executing |
| `STAKEHOLDER__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `STAKEHOLDER__TIMEOUT` | `300` | Maximum execution time in seconds |
| `STAKEHOLDER__NOTIFY` | `true` | Send notifications on completion |

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