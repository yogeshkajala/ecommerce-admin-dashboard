# Model Trainer -- Workspace Configuration

## Overview
This workspace includes the **Model Trainer** agent. Use when orchestrating model training, managing experiments, tuning hyperparameters, or tracking training runs.

## Agent Invocation
- Use `@model-trainer` to invoke the agent directly
- Use `/model-trainer.prompt` for guided workflow prompts
- Use `/model-trainer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODEL_TRAINE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MODEL_TRAINE_DRY_RUN` | `false` | Preview changes without executing |
| `MODEL_TRAINE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MODEL_TRAINE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MODEL_TRAINE_NOTIFY` | `true` | Send notifications on completion |

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