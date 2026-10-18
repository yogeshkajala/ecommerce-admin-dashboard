# Strategy Selector -- Workspace Configuration

## Overview
This workspace includes the **Strategy Selector** agent. Use when selecting 7R migration strategy per workload based on compatibility, cost, timeline, and business requirements.

## Agent Invocation
- Use `@strategy-selector` to invoke the agent directly
- Use `/strategy-selector.prompt` for guided workflow prompts
- Use `/strategy-selector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STRATEGY_SEL_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `STRATEGY_SEL_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `STRATEGY_SEL_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `STRATEGY_SEL_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `STRATEGY_SEL_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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