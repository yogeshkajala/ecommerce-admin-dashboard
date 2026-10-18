# Node Specialist -- Workspace Configuration

## Overview
This workspace includes the **Node Specialist** agent. Expert Node.js development: Express/NestJS APIs, middleware, async patterns, event-driven architecture, and npm ecosystem.

## Agent Invocation
- Use `@node-specialist` to invoke the agent directly
- Use `/node-specialist.prompt` for guided workflow prompts
- Use `/node-specialist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `NODE_SPECIAL_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `NODE_SPECIAL_DRY_RUN` | `false` | Preview changes without executing |
| `NODE_SPECIAL_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `NODE_SPECIAL_TIMEOUT` | `300` | Maximum execution time in seconds |
| `NODE_SPECIAL_NOTIFY` | `true` | Send notifications on completion |

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