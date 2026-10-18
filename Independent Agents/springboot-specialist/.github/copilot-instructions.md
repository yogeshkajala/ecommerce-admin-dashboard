# Springboot Specialist -- Workspace Configuration

## Overview
This workspace includes the **Springboot Specialist** agent. Expert Spring Boot microservices: Spring Cloud, service discovery, config server, circuit breakers, and distributed tracing.

## Agent Invocation
- Use `@springboot-specialist` to invoke the agent directly
- Use `/springboot-specialist.prompt` for guided workflow prompts
- Use `/springboot-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SPRINGBOOT_S_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SPRINGBOOT_S_DRY_RUN` | `false` | Preview changes without executing |
| `SPRINGBOOT_S_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SPRINGBOOT_S_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SPRINGBOOT_S_NOTIFY` | `true` | Send notifications on completion |

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