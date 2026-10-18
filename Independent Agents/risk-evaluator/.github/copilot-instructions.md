# Risk Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Risk Evaluator** agent. Use when evaluating transformation risks, scoring likelihood -- impact, assessing blast radius, or planning risk mitigations for migration and modernization.

## Agent Invocation
- Use `@risk-evaluator` to invoke the agent directly
- Use `/risk-evaluator.prompt` for guided workflow prompts
- Use `/risk-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RISK_EVALUAT_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `RISK_EVALUAT_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `RISK_EVALUAT_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `RISK_EVALUAT_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `RISK_EVALUAT_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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