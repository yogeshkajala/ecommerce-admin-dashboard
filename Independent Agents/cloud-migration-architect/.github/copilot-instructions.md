# Cloud Migration Architect -- Workspace Configuration

## Overview
This workspace includes the **Cloud Migration Architect** agent. Use when designing target cloud architecture, networking, security, and data migration strategy for cloud migration.

## Agent Invocation
- Use `@cloud-migration-architect` to invoke the agent directly
- Use `/cloud-migration-architect.prompt` for guided workflow prompts
- Use `/cloud-migration-architect-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CLOUD_MIGRAT_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `CLOUD_MIGRAT_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `CLOUD_MIGRAT_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `CLOUD_MIGRAT_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `CLOUD_MIGRAT_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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