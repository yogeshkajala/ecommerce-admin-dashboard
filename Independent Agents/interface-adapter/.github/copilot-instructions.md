# Interface Adapter -- Workspace Configuration

## Overview
This workspace includes the **Interface Adapter** agent. Use when building adapter layers between legacy and modern interfaces during coexistence.

## Agent Invocation
- Use `@interface-adapter` to invoke the agent directly
- Use `/interface-adapter.prompt` for guided workflow prompts
- Use `/interface-adapter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INTERFACE_AD_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `INTERFACE_AD_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `INTERFACE_AD_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `INTERFACE_AD_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `INTERFACE_AD_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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