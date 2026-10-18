# Adapter Builder -- Workspace Configuration

## Overview
This workspace includes the **Adapter Builder** agent. Build adapters and anti-corruption layers for legacy-modern coexistence.

## Agent Invocation
- Use `@adapter-builder` to invoke the agent directly
- Use `/adapter-builder.prompt` for guided workflow prompts
- Use `/adapter-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ADAPTER_BUIL_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `ADAPTER_BUIL_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `ADAPTER_BUIL_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `ADAPTER_BUIL_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `ADAPTER_BUIL_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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