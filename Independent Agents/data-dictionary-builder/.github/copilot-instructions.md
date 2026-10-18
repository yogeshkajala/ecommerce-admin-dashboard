# Data Dictionary Builder -- Workspace Configuration

## Overview
This workspace includes the **Data Dictionary Builder** agent. Use when building comprehensive data dictionaries from legacy databases, file structures, and application data models.

## Agent Invocation
- Use `@data-dictionary-builder` to invoke the agent directly
- Use `/data-dictionary-builder.prompt` for guided workflow prompts
- Use `/data-dictionary-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_DICTION_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `DATA_DICTION_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `DATA_DICTION_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `DATA_DICTION_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `DATA_DICTION_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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