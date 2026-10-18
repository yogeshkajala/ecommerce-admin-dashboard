# Upgrade Path Finder -- Workspace Configuration

## Overview
This workspace includes the **Upgrade Path Finder** agent. Use when finding optimal upgrade path (incremental or direct) between current and target versions.

## Agent Invocation
- Use `@upgrade-path-finder` to invoke the agent directly
- Use `/upgrade-path-finder.prompt` for guided workflow prompts
- Use `/upgrade-path-finder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UPGRADE_PATH_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `UPGRADE_PATH_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `UPGRADE_PATH_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `UPGRADE_PATH_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `UPGRADE_PATH_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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