# Migration Step Sequencer -- Workspace Configuration

## Overview
This workspace includes the **Migration Step Sequencer** agent. Sequence upgrade steps respecting dependency order and test gates.

## Agent Invocation
- Use `@migration-step-sequencer` to invoke the agent directly
- Use `/migration-step-sequencer.prompt` for guided workflow prompts
- Use `/migration-step-sequencer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MIGRATION_ST_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MIGRATION_ST_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MIGRATION_ST_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MIGRATION_ST_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MIGRATION_ST_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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