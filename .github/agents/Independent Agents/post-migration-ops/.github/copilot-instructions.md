# Post Migration Ops -- Workspace Configuration

## Overview
This workspace includes the **Post Migration Ops** agent. Use when setting up post-migration operations -- monitoring, cost optimization, performance tuning, and documentation.

## Agent Invocation
- Use `@post-migration-ops` to invoke the agent directly
- Use `/post-migration-ops.prompt` for guided workflow prompts
- Use `/post-migration-ops-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `POST_MIGRATI_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `POST_MIGRATI_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `POST_MIGRATI_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `POST_MIGRATI_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `POST_MIGRATI_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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