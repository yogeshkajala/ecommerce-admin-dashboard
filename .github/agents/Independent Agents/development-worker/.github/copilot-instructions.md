# Development Worker -- Workspace Configuration

## Overview
This workspace includes the **Development Worker** agent. Execute code changes for migration: refactoring, API updates, dependency upgrades, and framework transitions.

## Agent Invocation
- Use `@development-worker` to invoke the agent directly
- Use `/development-worker.prompt` for guided workflow prompts
- Use `/development-worker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEVELOPMENT__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `DEVELOPMENT__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `DEVELOPMENT__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `DEVELOPMENT__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `DEVELOPMENT__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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