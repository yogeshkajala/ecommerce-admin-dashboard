# Tech Debt Assessor -- Workspace Configuration

## Overview
This workspace includes the **Tech Debt Assessor** agent. Use when assessing technical debt, code complexity (cyclomatic/cognitive), duplication, code smells, dead code, or identifying refactoring priorities.

## Agent Invocation
- Use `@tech-debt-assessor` to invoke the agent directly
- Use `/tech-debt-assessor.prompt` for guided workflow prompts
- Use `/tech-debt-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TECH_DEBT_AS_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `TECH_DEBT_AS_DRY_RUN` | `false` | Preview changes without executing |
| `TECH_DEBT_AS_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `TECH_DEBT_AS_TIMEOUT` | `300` | Maximum execution time in seconds |
| `TECH_DEBT_AS_NOTIFY` | `true` | Send notifications on completion |

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