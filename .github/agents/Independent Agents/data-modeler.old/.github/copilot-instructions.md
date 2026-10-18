# Data Modeler -- Workspace Configuration

## Overview
This workspace includes the **Data Modeler** agent. Design data models: ERDs, domain models, data dictionaries, and relationship mapping.

## Agent Invocation
- Use `@data-modeler` to invoke the agent directly
- Use `/data-modeler.prompt` for guided workflow prompts
- Use `/data-modeler-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_MODELER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DATA_MODELER_DRY_RUN` | `false` | Preview changes without executing |
| `DATA_MODELER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DATA_MODELER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DATA_MODELER_NOTIFY` | `true` | Send notifications on completion |

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