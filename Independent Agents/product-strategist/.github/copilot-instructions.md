# Product Strategist -- Workspace Configuration

## Overview
This workspace includes the **Product Strategist** agent. Use when defining product vision, building roadmaps, prioritizing features, and tracking OKRs.

## Agent Invocation
- Use `@product-strategist` to invoke the agent directly
- Use `/product-strategist.prompt` for guided workflow prompts
- Use `/product-strategist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PRODUCT_STRA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PRODUCT_STRA_DRY_RUN` | `false` | Preview changes without executing |
| `PRODUCT_STRA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PRODUCT_STRA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PRODUCT_STRA_NOTIFY` | `true` | Send notifications on completion |

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