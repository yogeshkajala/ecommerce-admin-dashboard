# Target Architecture Designer -- Workspace Configuration

## Overview
This workspace includes the **Target Architecture Designer** agent. Use when designing target modern architecture that preserves all legacy business rules and capabilities.

## Agent Invocation
- Use `@target-architecture-designer` to invoke the agent directly
- Use `/target-architecture-designer.prompt` for guided workflow prompts
- Use `/target-architecture-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TARGET_ARCHI_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `TARGET_ARCHI_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `TARGET_ARCHI_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `TARGET_ARCHI_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `TARGET_ARCHI_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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