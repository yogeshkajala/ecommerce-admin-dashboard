# Risk Mitigator -- Workspace Configuration

## Overview
This workspace includes the **Risk Mitigator** agent. Identify project risks, assess impact/probability, plan mitigation actions.

## Agent Invocation
- Use `@risk-mitigator` to invoke the agent directly
- Use `/risk-mitigator.prompt` for guided workflow prompts
- Use `/risk-mitigator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RISK_MITIGAT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `RISK_MITIGAT_DRY_RUN` | `false` | Preview changes without executing |
| `RISK_MITIGAT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `RISK_MITIGAT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `RISK_MITIGAT_NOTIFY` | `true` | Send notifications on completion |

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