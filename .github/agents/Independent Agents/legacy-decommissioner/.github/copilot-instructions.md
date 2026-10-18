# Legacy Decommissioner -- Workspace Configuration

## Overview
This workspace includes the **Legacy Decommissioner** agent. Use when planning and executing legacy system decommissioning including dependency validation, data archival, license termination, and infrastructure teardown.

## Agent Invocation
- Use `@legacy-decommissioner` to invoke the agent directly
- Use `/legacy-decommissioner.prompt` for guided workflow prompts
- Use `/legacy-decommissioner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_DECOM_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `LEGACY_DECOM_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `LEGACY_DECOM_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `LEGACY_DECOM_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `LEGACY_DECOM_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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