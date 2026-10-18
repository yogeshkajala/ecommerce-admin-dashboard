# Optimization Advisor -- Workspace Configuration

## Overview
This workspace includes the **Optimization Advisor** agent. Use when recommending proactive optimizations to prevent recurring failures and improve system resilience.

## Agent Invocation
- Use `@optimization-advisor` to invoke the agent directly
- Use `/optimization-advisor.prompt` for guided workflow prompts
- Use `/optimization-advisor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `OPTIMIZATION_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `OPTIMIZATION_DRY_RUN` | `false` | Preview changes without executing |
| `OPTIMIZATION_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `OPTIMIZATION_TIMEOUT` | `300` | Maximum execution time in seconds |
| `OPTIMIZATION_NOTIFY` | `true` | Send notifications on completion |

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