# Gate Reviewer -- Workspace Configuration

## Overview
This workspace includes the **Gate Reviewer** agent. Use when conducting quality gate reviews at project milestones to evaluate deliverable readiness.

## Agent Invocation
- Use `@gate-reviewer` to invoke the agent directly
- Use `/gate-reviewer.prompt` for guided workflow prompts
- Use `/gate-reviewer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `GATE_REVIEWE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `GATE_REVIEWE_DRY_RUN` | `false` | Preview changes without executing |
| `GATE_REVIEWE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `GATE_REVIEWE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `GATE_REVIEWE_NOTIFY` | `true` | Send notifications on completion |

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