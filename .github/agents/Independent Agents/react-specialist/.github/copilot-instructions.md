# React Specialist -- Workspace Configuration

## Overview
This workspace includes the **React Specialist** agent. Expert React/Next.js development: functional components, hooks, SSR/SSG, state management, and React ecosystem tooling.

## Agent Invocation
- Use `@react-specialist` to invoke the agent directly
- Use `/react-specialist.prompt` for guided workflow prompts
- Use `/react-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REACT_SPECIA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `REACT_SPECIA_DRY_RUN` | `false` | Preview changes without executing |
| `REACT_SPECIA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `REACT_SPECIA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `REACT_SPECIA_NOTIFY` | `true` | Send notifications on completion |

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