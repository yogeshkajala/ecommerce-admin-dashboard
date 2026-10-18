# Fact Checker -- Workspace Configuration

## Overview
This workspace includes the **Fact Checker** agent. Use when verifying factual claims in AI-generated outputs, cross-referencing assertions against knowledge bases, detecting fabricated data, or validating numerical claims.

## Agent Invocation
- Use `@fact-checker` to invoke the agent directly
- Use `/fact-checker.prompt` for guided workflow prompts
- Use `/fact-checker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FACT_CHECKER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FACT_CHECKER_DRY_RUN` | `false` | Preview changes without executing |
| `FACT_CHECKER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FACT_CHECKER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FACT_CHECKER_NOTIFY` | `true` | Send notifications on completion |

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