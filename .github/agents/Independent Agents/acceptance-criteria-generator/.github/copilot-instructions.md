# Acceptance Criteria Generator -- Workspace Configuration

## Overview
This workspace includes the **Acceptance Criteria Generator** agent. Use when generating measurable acceptance criteria in Given/When/Then (Gherkin) format for each requirement, including positive, negative, and edge case scenarios.

## Agent Invocation
- Use `@acceptance-criteria-generator` to invoke the agent directly
- Use `/acceptance-criteria-generator.prompt` for guided workflow prompts
- Use `/acceptance-criteria-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ACCEPTANCE_C_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `ACCEPTANCE_C_DRY_RUN` | `false` | Preview changes without executing |
| `ACCEPTANCE_C_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `ACCEPTANCE_C_TIMEOUT` | `300` | Maximum execution time in seconds |
| `ACCEPTANCE_C_NOTIFY` | `true` | Send notifications on completion |

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