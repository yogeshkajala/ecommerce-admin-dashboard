# Batch Job Migrator -- Workspace Configuration

## Overview
This workspace includes the **Batch Job Migrator** agent. Use when migrating legacy batch jobs to modern scheduling systems with equivalent functionality.

## Agent Invocation
- Use `@batch-job-migrator` to invoke the agent directly
- Use `/batch-job-migrator.prompt` for guided workflow prompts
- Use `/batch-job-migrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BATCH_JOB_MI_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `BATCH_JOB_MI_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `BATCH_JOB_MI_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `BATCH_JOB_MI_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `BATCH_JOB_MI_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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