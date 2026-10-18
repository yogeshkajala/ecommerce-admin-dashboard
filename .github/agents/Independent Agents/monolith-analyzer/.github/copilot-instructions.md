# Monolith Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Monolith Analyzer** agent. Use when analyzing monolithic applications to identify domain boundaries, coupling patterns, hotspots, and decomposition candidates.

## Agent Invocation
- Use `@monolith-analyzer` to invoke the agent directly
- Use `/monolith-analyzer.prompt` for guided workflow prompts
- Use `/monolith-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MONOLITH_ANA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MONOLITH_ANA_DRY_RUN` | `false` | Preview changes without executing |
| `MONOLITH_ANA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MONOLITH_ANA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MONOLITH_ANA_NOTIFY` | `true` | Send notifications on completion |

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