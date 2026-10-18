# Market Researcher -- Workspace Configuration

## Overview
This workspace includes the **Market Researcher** agent. Use when researching market trends, competitor analysis, and user needs to inform product strategy.

## Agent Invocation
- Use `@market-researcher` to invoke the agent directly
- Use `/market-researcher.prompt` for guided workflow prompts
- Use `/market-researcher-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MARKET_RESEA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MARKET_RESEA_DRY_RUN` | `false` | Preview changes without executing |
| `MARKET_RESEA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MARKET_RESEA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MARKET_RESEA_NOTIFY` | `true` | Send notifications on completion |

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