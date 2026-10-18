# Constraint Identifier -- Workspace Configuration

## Overview
This workspace includes the **Constraint Identifier** agent. Use when identifying technical, business, regulatory, and operational constraints that impact modernization.

## Agent Invocation
- Use `@constraint-identifier` to invoke the agent directly
- Use `/constraint-identifier.prompt` for guided workflow prompts
- Use `/constraint-identifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONSTRAINT_I_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `CONSTRAINT_I_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `CONSTRAINT_I_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `CONSTRAINT_I_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `CONSTRAINT_I_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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