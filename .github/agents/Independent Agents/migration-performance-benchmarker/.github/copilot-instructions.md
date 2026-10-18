# Migration Performance Benchmarker -- Workspace Configuration

## Overview
This workspace includes the **Migration Performance Benchmarker** agent. Benchmark migrated system performance against legacy baselines and SLA targets.

## Agent Invocation
- Use `@migration-performance-benchmarker` to invoke the agent directly
- Use `/migration-performance-benchmarker.prompt` for guided workflow prompts
- Use `/migration-performance-benchmarker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_PE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_PE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_PE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_PE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_PE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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