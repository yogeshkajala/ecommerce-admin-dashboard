# Event Bus Integrator -- Workspace Configuration

## Overview
This workspace includes the **Event Bus Integrator** agent. Use when setting up event-driven communication between extracted microservices.

## Agent Invocation
- Use `@event-bus-integrator` to invoke the agent directly
- Use `/event-bus-integrator.prompt` for guided workflow prompts
- Use `/event-bus-integrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EVENT_BUS_IN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EVENT_BUS_IN_DRY_RUN` | `false` | Preview changes without executing |
| `EVENT_BUS_IN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EVENT_BUS_IN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EVENT_BUS_IN_NOTIFY` | `true` | Send notifications on completion |

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