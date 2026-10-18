# Pattern Detector -- Workspace Configuration

## Overview
This workspace includes the **Pattern Detector** agent. Use when detecting prompt injection patterns, identifying adversarial prompt techniques, matching known injection signatures, or analyzing inputs for novel attack vectors.

## Agent Invocation
- Use `@pattern-detector` to invoke the agent directly
- Use `/pattern-detector.prompt` for guided workflow prompts
- Use `/pattern-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PATTERN_DETE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PATTERN_DETE_DRY_RUN` | `false` | Preview changes without executing |
| `PATTERN_DETE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PATTERN_DETE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PATTERN_DETE_NOTIFY` | `true` | Send notifications on completion |

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