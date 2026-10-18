# Service Boundary Designer -- Workspace Configuration

## Overview
This workspace includes the **Service Boundary Designer** agent. Use when defining microservice boundaries based on bounded contexts, ensuring each service owns a single domain.

## Agent Invocation
- Use `@service-boundary-designer` to invoke the agent directly
- Use `/service-boundary-designer.prompt` for guided workflow prompts
- Use `/service-boundary-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_BOUN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SERVICE_BOUN_DRY_RUN` | `false` | Preview changes without executing |
| `SERVICE_BOUN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SERVICE_BOUN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SERVICE_BOUN_NOTIFY` | `true` | Send notifications on completion |

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