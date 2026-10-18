# Parallel Run Manager -- Workspace Configuration

## Overview
This workspace includes the **Parallel Run Manager** agent. Use when managing parallel runs between legacy and migrated systems including transaction comparison, discrepancy analysis, and confidence scoring.

## Agent Invocation
- Use `@parallel-run-manager` to invoke the agent directly
- Use `/parallel-run-manager.prompt` for guided workflow prompts
- Use `/parallel-run-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PARALLEL_RUN_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `PARALLEL_RUN_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `PARALLEL_RUN_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `PARALLEL_RUN_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `PARALLEL_RUN_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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