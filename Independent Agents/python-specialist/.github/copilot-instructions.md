# Python Specialist -- Workspace Configuration

## Overview
This workspace includes the **Python Specialist** agent. Expert Python development: FastAPI, Django, Flask, SQLAlchemy, and data processing patterns.

## Agent Invocation
- Use `@python-specialist` to invoke the agent directly
- Use `/python-specialist.prompt` for guided workflow prompts
- Use `/python-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PYTHON_SPECI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PYTHON_SPECI_DRY_RUN` | `false` | Preview changes without executing |
| `PYTHON_SPECI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PYTHON_SPECI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PYTHON_SPECI_NOTIFY` | `true` | Send notifications on completion |

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