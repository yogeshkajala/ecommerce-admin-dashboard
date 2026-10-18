# Serverless Designer -- Workspace Configuration

## Overview
This workspace includes the **Serverless Designer** agent. Use when designing serverless architectures with event triggers, function composition, and cold start optimization.

## Agent Invocation
- Use `@serverless-designer` to invoke the agent directly
- Use `/serverless-designer.prompt` for guided workflow prompts
- Use `/serverless-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVERLESS_D_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SERVERLESS_D_DRY_RUN` | `false` | Preview changes without executing |
| `SERVERLESS_D_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SERVERLESS_D_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SERVERLESS_D_NOTIFY` | `true` | Send notifications on completion |

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