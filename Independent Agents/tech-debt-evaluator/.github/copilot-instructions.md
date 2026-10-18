# Tech Debt Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Tech Debt Evaluator** agent. Use when evaluating technical debt that must be resolved before or during cloud modernization.

## Agent Invocation
- Use `@tech-debt-evaluator` to invoke the agent directly
- Use `/tech-debt-evaluator.prompt` for guided workflow prompts
- Use `/tech-debt-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TECH_DEBT_EV_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `TECH_DEBT_EV_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `TECH_DEBT_EV_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `TECH_DEBT_EV_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `TECH_DEBT_EV_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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