# Migration Complexity Scorer -- Workspace Configuration

## Overview
This workspace includes the **Migration Complexity Scorer** agent. Use when scoring migration complexity based on codebase size, technology age, integration points, and business criticality.

## Agent Invocation
- Use `@migration-complexity-scorer` to invoke the agent directly
- Use `/migration-complexity-scorer.prompt` for guided workflow prompts
- Use `/migration-complexity-scorer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_CO_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_CO_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_CO_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_CO_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_CO_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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