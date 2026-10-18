# Migration Tester -- Workspace Configuration

## Overview
This workspace includes the **Migration Tester** agent. Use when testing migrated workloads for functionality, performance, security, and data integrity after cloud migration.

## Agent Invocation
- Use `@migration-tester` to invoke the agent directly
- Use `/migration-tester.prompt` for guided workflow prompts
- Use `/migration-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_TE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_TE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_TE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_TE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_TE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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