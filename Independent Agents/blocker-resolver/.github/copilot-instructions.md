# Blocker Resolver -- Workspace Configuration

## Overview
This workspace includes the **Blocker Resolver** agent. Use when identifying, triaging, and resolving delivery blockers with escalation paths.

## Agent Invocation
- Use `@blocker-resolver` to invoke the agent directly
- Use `/blocker-resolver.prompt` for guided workflow prompts
- Use `/blocker-resolver-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BLOCKER_RESO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `BLOCKER_RESO_DRY_RUN` | `false` | Preview changes without executing |
| `BLOCKER_RESO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `BLOCKER_RESO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `BLOCKER_RESO_NOTIFY` | `true` | Send notifications on completion |

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