# Error Tracker -- Workspace Configuration

## Overview
This workspace includes the **Error Tracker** agent. Use when tracking and analyzing errors after upgrades to detect new error patterns and rate increases.

## Agent Invocation
- Use `@error-tracker` to invoke the agent directly
- Use `/error-tracker.prompt` for guided workflow prompts
- Use `/error-tracker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ERROR_TRACKE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `ERROR_TRACKE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `ERROR_TRACKE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `ERROR_TRACKE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `ERROR_TRACKE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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