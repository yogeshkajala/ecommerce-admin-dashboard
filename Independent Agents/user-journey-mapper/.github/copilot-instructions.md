# User Journey Mapper -- Workspace Configuration

## Overview
This workspace includes the **User Journey Mapper** agent. Use when mapping user journeys to understand modernization impact on end-user experiences and workflows.

## Agent Invocation
- Use `@user-journey-mapper` to invoke the agent directly
- Use `/user-journey-mapper.prompt` for guided workflow prompts
- Use `/user-journey-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `USER_JOURNEY_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `USER_JOURNEY_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `USER_JOURNEY_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `USER_JOURNEY_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `USER_JOURNEY_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

## Key Conventions
- All migrations require rollback plan before execution
- Data validation is mandatory post-migration
- Maximum downtime window must not be exceeded
- Parallel migration streams follow configured limit
- Legacy and target systems run in parallel during validation

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations