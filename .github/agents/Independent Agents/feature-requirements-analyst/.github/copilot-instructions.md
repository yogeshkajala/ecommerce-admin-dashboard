# Feature Requirements Analyst -- Workspace Configuration

## Overview
This workspace includes the **Feature Requirements Analyst** agent. Use when gathering and documenting feature requirements from stakeholders, user stories, acceptance criteria, and dependency analysis.

## Agent Invocation
- Use `@feature-requirements-analyst` to invoke the agent directly
- Use `/feature-requirements-analyst.prompt` for guided workflow prompts
- Use `/feature-requirements-analyst-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_REQU_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FEATURE_REQU_DRY_RUN` | `false` | Preview changes without executing |
| `FEATURE_REQU_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FEATURE_REQU_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FEATURE_REQU_NOTIFY` | `true` | Send notifications on completion |

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