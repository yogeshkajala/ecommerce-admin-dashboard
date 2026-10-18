# Trade Off Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Trade Off Analyzer** agent. Use when analyzing architectural trade-offs between competing quality attributes and documenting decisions in ADR format.

## Agent Invocation
- Use `@trade-off-analyzer` to invoke the agent directly
- Use `/trade-off-analyzer.prompt` for guided workflow prompts
- Use `/trade-off-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TRADE_OFF_AN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `TRADE_OFF_AN_DRY_RUN` | `false` | Preview changes without executing |
| `TRADE_OFF_AN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `TRADE_OFF_AN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `TRADE_OFF_AN_NOTIFY` | `true` | Send notifications on completion |

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