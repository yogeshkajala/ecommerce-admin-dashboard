# Legacy Inventory Scanner -- Workspace Configuration

## Overview
This workspace includes the **Legacy Inventory Scanner** agent. Use when scanning legacy systems to inventory programs, modules, batch jobs, databases, interfaces, and dependencies.

## Agent Invocation
- Use `@legacy-inventory-scanner` to invoke the agent directly
- Use `/legacy-inventory-scanner.prompt` for guided workflow prompts
- Use `/legacy-inventory-scanner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_INVEN_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `LEGACY_INVEN_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `LEGACY_INVEN_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `LEGACY_INVEN_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `LEGACY_INVEN_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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