# Complexity Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Complexity Evaluator** agent. Evaluate migration complexity: language, framework, coupling, data volume.

## Agent Invocation
- Use `@complexity-evaluator` to invoke the agent directly
- Use `/complexity-evaluator.prompt` for guided workflow prompts
- Use `/complexity-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPLEXITY_E_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `COMPLEXITY_E_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `COMPLEXITY_E_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `COMPLEXITY_E_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `COMPLEXITY_E_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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