# Mitigation Planner -- Workspace Configuration

## Overview
This workspace includes the **Mitigation Planner** agent. Use when developing mitigation strategies and action plans for assessed project risks.

## Agent Invocation
- Use `@mitigation-planner` to invoke the agent directly
- Use `/mitigation-planner.prompt` for guided workflow prompts
- Use `/mitigation-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MITIGATION_P_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MITIGATION_P_DRY_RUN` | `false` | Preview changes without executing |
| `MITIGATION_P_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MITIGATION_P_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MITIGATION_P_NOTIFY` | `true` | Send notifications on completion |

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