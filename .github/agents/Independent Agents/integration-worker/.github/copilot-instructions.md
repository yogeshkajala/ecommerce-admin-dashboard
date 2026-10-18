# Integration Worker -- Workspace Configuration

## Overview
This workspace includes the **Integration Worker** agent. Validate integrations between migrated and legacy systems: API compatibility, data sync, and event flow.

## Agent Invocation
- Use `@integration-worker` to invoke the agent directly
- Use `/integration-worker.prompt` for guided workflow prompts
- Use `/integration-worker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INTEGRATION__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `INTEGRATION__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `INTEGRATION__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `INTEGRATION__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `INTEGRATION__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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