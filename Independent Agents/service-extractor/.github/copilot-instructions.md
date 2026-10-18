# Service Extractor -- Workspace Configuration

## Overview
This workspace includes the **Service Extractor** agent. Use when extracting service code from monolith following strangler fig pattern with anti-corruption layer.

## Agent Invocation
- Use `@service-extractor` to invoke the agent directly
- Use `/service-extractor.prompt` for guided workflow prompts
- Use `/service-extractor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_EXTR_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SERVICE_EXTR_DRY_RUN` | `false` | Preview changes without executing |
| `SERVICE_EXTR_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SERVICE_EXTR_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SERVICE_EXTR_NOTIFY` | `true` | Send notifications on completion |

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