# Complexity Scorer -- Workspace Configuration

## Overview
This workspace includes the **Complexity Scorer** agent. Score modernization complexity based on coupling, data, and integration factors.

## Agent Invocation
- Use `@complexity-scorer` to invoke the agent directly
- Use `/complexity-scorer.prompt` for guided workflow prompts
- Use `/complexity-scorer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPLEXITY_S_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `COMPLEXITY_S_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `COMPLEXITY_S_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `COMPLEXITY_S_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `COMPLEXITY_S_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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