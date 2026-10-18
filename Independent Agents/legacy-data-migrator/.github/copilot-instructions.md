# Legacy Data Migrator -- Workspace Configuration

## Overview
This workspace includes the **Legacy Data Migrator** agent. Migrate data from legacy formats (VSAM, flat files, IMS) to modern databases.

## Agent Invocation
- Use `@legacy-data-migrator` to invoke the agent directly
- Use `/legacy-data-migrator.prompt` for guided workflow prompts
- Use `/legacy-data-migrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_DATA__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `LEGACY_DATA__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `LEGACY_DATA__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `LEGACY_DATA__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `LEGACY_DATA__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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