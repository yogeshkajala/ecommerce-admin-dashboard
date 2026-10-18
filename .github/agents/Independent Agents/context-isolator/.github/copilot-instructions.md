# Context Isolator -- Workspace Configuration

## Overview
This workspace includes the **Context Isolator** agent. Use when enforcing context boundaries between agents, preventing privilege escalation through prompt manipulation, validating context integrity, or isolating untrusted content.

## Agent Invocation
- Use `@context-isolator` to invoke the agent directly
- Use `/context-isolator.prompt` for guided workflow prompts
- Use `/context-isolator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTEXT_ISOL_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CONTEXT_ISOL_DRY_RUN` | `false` | Preview changes without executing |
| `CONTEXT_ISOL_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CONTEXT_ISOL_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CONTEXT_ISOL_NOTIFY` | `true` | Send notifications on completion |

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