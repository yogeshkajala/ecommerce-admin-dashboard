# Vue Specialist -- Workspace Configuration

## Overview
This workspace includes the **Vue Specialist** agent. Expert Vue.js/Nuxt development: Composition API, composables, Pinia state, and Vue ecosystem tooling.

## Agent Invocation
- Use `@vue-specialist` to invoke the agent directly
- Use `/vue-specialist.prompt` for guided workflow prompts
- Use `/vue-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `VUE_SPECIALI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `VUE_SPECIALI_DRY_RUN` | `false` | Preview changes without executing |
| `VUE_SPECIALI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `VUE_SPECIALI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `VUE_SPECIALI_NOTIFY` | `true` | Send notifications on completion |

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