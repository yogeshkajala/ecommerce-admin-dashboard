# Snapshot Manager -- Workspace Configuration

## Overview
This workspace includes the **Snapshot Manager** agent. Use when managing pre-upgrade snapshots -- creation, verification, storage, and restore point management.

## Agent Invocation
- Use `@snapshot-manager` to invoke the agent directly
- Use `/snapshot-manager.prompt` for guided workflow prompts
- Use `/snapshot-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SNAPSHOT_MAN_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `SNAPSHOT_MAN_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `SNAPSHOT_MAN_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `SNAPSHOT_MAN_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `SNAPSHOT_MAN_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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