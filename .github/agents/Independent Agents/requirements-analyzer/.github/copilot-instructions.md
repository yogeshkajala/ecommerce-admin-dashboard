# Requirements Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Requirements Analyzer** agent. Use when analyzing, decomposing, deduplicating, and prioritizing requirements for specification writing.

## Agent Invocation
- Use `@requirements-analyzer` to invoke the agent directly
- Use `/requirements-analyzer.prompt` for guided workflow prompts
- Use `/requirements-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REQUIREMENTS_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `REQUIREMENTS_DRY_RUN` | `false` | Preview changes without executing |
| `REQUIREMENTS_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `REQUIREMENTS_TIMEOUT` | `300` | Maximum execution time in seconds |
| `REQUIREMENTS_NOTIFY` | `true` | Send notifications on completion |

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