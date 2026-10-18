# Solution Architect -- Workspace Configuration

## Overview
This workspace includes the **Solution Architect** agent. Use when designing system architecture, selecting patterns, analyzing trade-offs, designing API contracts, and documenting architecture decisions.

## Agent Invocation
- Use `@solution-architect` to invoke the agent directly
- Use `/solution-architect.prompt` for guided workflow prompts
- Use `/solution-architect-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SOLUTION_ARC_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SOLUTION_ARC_DRY_RUN` | `false` | Preview changes without executing |
| `SOLUTION_ARC_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SOLUTION_ARC_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SOLUTION_ARC_NOTIFY` | `true` | Send notifications on completion |

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