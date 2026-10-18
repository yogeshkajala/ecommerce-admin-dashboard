# Skill Mapper -- Workspace Configuration

## Overview
This workspace includes the **Skill Mapper** agent. Use when mapping project skill requirements against team capabilities and identifying gaps with training or hiring plans.

## Agent Invocation
- Use `@skill-mapper` to invoke the agent directly
- Use `/skill-mapper.prompt` for guided workflow prompts
- Use `/skill-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SKILL_MAPPER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SKILL_MAPPER_DRY_RUN` | `false` | Preview changes without executing |
| `SKILL_MAPPER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SKILL_MAPPER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SKILL_MAPPER_NOTIFY` | `true` | Send notifications on completion |

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