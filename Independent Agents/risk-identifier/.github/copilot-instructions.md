# Risk Identifier -- Workspace Configuration

## Overview
This workspace includes the **Risk Identifier** agent. Use when identifying project risks across technical, schedule, resource, and external dimensions.

## Agent Invocation
- Use `@risk-identifier` to invoke the agent directly
- Use `/risk-identifier.prompt` for guided workflow prompts
- Use `/risk-identifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RISK_IDENTIF_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `RISK_IDENTIF_DRY_RUN` | `false` | Preview changes without executing |
| `RISK_IDENTIF_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `RISK_IDENTIF_TIMEOUT` | `300` | Maximum execution time in seconds |
| `RISK_IDENTIF_NOTIFY` | `true` | Send notifications on completion |

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