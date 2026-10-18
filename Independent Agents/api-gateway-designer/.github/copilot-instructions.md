# Api Gateway Designer -- Workspace Configuration

## Overview
This workspace includes the **Api Gateway Designer** agent. Use when designing API gateway routing, BFF patterns, rate limiting, and cross-cutting concerns for microservices.

## Agent Invocation
- Use `@api-gateway-designer` to invoke the agent directly
- Use `/api-gateway-designer.prompt` for guided workflow prompts
- Use `/api-gateway-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `API_GATEWAY__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `API_GATEWAY__DRY_RUN` | `false` | Preview changes without executing |
| `API_GATEWAY__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `API_GATEWAY__TIMEOUT` | `300` | Maximum execution time in seconds |
| `API_GATEWAY__NOTIFY` | `true` | Send notifications on completion |

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