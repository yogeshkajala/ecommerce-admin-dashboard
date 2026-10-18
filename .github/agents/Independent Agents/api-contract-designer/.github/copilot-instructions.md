# Api Contract Designer -- Workspace Configuration

## Overview
This workspace includes the **Api Contract Designer** agent. Use when designing RESTful or GraphQL API contracts with versioning, error handling, pagination, authentication, and rate limiting standards.

## Agent Invocation
- Use `@api-contract-designer` to invoke the agent directly
- Use `/api-contract-designer.prompt` for guided workflow prompts
- Use `/api-contract-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `API_CONTRACT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `API_CONTRACT_DRY_RUN` | `false` | Preview changes without executing |
| `API_CONTRACT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `API_CONTRACT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `API_CONTRACT_NOTIFY` | `true` | Send notifications on completion |

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