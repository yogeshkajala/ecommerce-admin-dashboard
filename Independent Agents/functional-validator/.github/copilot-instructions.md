# Functional Validator -- Workspace Configuration

## Overview
This workspace includes the **Functional Validator** agent. Use when verifying that migrated applications function correctly including all features, integrations, and data access paths.

## Agent Invocation
- Use `@functional-validator` to invoke the agent directly
- Use `/functional-validator.prompt` for guided workflow prompts
- Use `/functional-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FUNCTIONAL_V_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `FUNCTIONAL_V_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `FUNCTIONAL_V_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `FUNCTIONAL_V_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `FUNCTIONAL_V_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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