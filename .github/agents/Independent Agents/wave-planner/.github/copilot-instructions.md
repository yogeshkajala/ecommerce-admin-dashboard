# Wave Planner -- Workspace Configuration

## Overview
This workspace includes the **Wave Planner** agent. Plan migration waves grouping related workloads with minimal cross-wave dependencies.

## Agent Invocation
- Use `@wave-planner` to invoke the agent directly
- Use `/wave-planner.prompt` for guided workflow prompts
- Use `/wave-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `WAVE_PLANNER_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `WAVE_PLANNER_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `WAVE_PLANNER_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `WAVE_PLANNER_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `WAVE_PLANNER_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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