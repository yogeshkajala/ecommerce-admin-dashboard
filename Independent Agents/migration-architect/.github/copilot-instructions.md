# Migration Architect -- Workspace Configuration

## Overview
This workspace includes the **Migration Architect** agent. Use when designing target architecture, data migration strategy, interface mapping, and coexistence patterns for legacy migration.

## Agent Invocation
- Use `@migration-architect` to invoke the agent directly
- Use `/migration-architect.prompt` for guided workflow prompts
- Use `/migration-architect-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_AR_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_AR_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_AR_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_AR_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_AR_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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