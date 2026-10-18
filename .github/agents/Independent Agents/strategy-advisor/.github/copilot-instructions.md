# Strategy Advisor -- Workspace Configuration

## Overview
This workspace includes the **Strategy Advisor** agent. Use when conducting application portfolio assessments, migration strategy planning (Gartner 6Rs), cloud readiness evaluation, modernization roadmapping, or risk-scored transformation planning.

## Agent Invocation
- Use `@strategy-advisor` to invoke the agent directly
- Use `/strategy-advisor.prompt` for guided workflow prompts
- Use `/strategy-advisor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STRATEGY_ADV_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `STRATEGY_ADV_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `STRATEGY_ADV_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `STRATEGY_ADV_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `STRATEGY_ADV_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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