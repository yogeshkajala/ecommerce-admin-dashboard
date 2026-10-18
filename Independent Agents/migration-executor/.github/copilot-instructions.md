# Migration Executor -- Workspace Configuration

## Overview
This workspace includes the **Migration Executor** agent. Use when executing migration including infrastructure provisioning, data migration, application migration, and DNS cutover.

## Agent Invocation
- Use `@migration-executor` to invoke the agent directly
- Use `/migration-executor.prompt` for guided workflow prompts
- Use `/migration-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_EX_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_EX_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_EX_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_EX_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_EX_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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