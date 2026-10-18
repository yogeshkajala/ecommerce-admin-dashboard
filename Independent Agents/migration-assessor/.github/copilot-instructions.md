# Migration Assessor -- Workspace Configuration

## Overview
This workspace includes the **Migration Assessor** agent. Use when assessing workloads for cloud migration including discovery, compatibility checking, cost modeling, and risk evaluation.

## Agent Invocation
- Use `@migration-assessor` to invoke the agent directly
- Use `/migration-assessor.prompt` for guided workflow prompts
- Use `/migration-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_AS_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_AS_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_AS_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_AS_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_AS_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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