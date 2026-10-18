# Confidence Calibrator -- Workspace Configuration

## Overview
This workspace includes the **Confidence Calibrator** agent. Use when calibrating AI confidence scores, detecting overconfident or underconfident outputs, adjusting certainty levels based on evidence quality, or flagging low-confidence claims.

## Agent Invocation
- Use `@confidence-calibrator` to invoke the agent directly
- Use `/confidence-calibrator.prompt` for guided workflow prompts
- Use `/confidence-calibrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONFIDENCE_C_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CONFIDENCE_C_DRY_RUN` | `false` | Preview changes without executing |
| `CONFIDENCE_C_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CONFIDENCE_C_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CONFIDENCE_C_NOTIFY` | `true` | Send notifications on completion |

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