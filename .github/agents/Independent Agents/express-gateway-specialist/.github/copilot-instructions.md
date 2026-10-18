# Express Gateway Specialist -- Workspace Configuration

## Overview
This workspace includes the **Express Gateway Specialist** agent. API gateway development: routing, rate limiting, authentication, load balancing, and request transformation.

## Agent Invocation
- Use `@express-gateway-specialist` to invoke the agent directly
- Use `/express-gateway-specialist.prompt` for guided workflow prompts
- Use `/express-gateway-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EXPRESS_GATE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EXPRESS_GATE_DRY_RUN` | `false` | Preview changes without executing |
| `EXPRESS_GATE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EXPRESS_GATE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EXPRESS_GATE_NOTIFY` | `true` | Send notifications on completion |

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