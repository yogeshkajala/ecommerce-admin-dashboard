# Upgrade Assessor -- Workspace Configuration

## Overview
This workspace includes the **Upgrade Assessor** agent. Use when assessing upgrade feasibility including version compatibility, breaking changes, dependency health, and risk evaluation.

## Agent Invocation
- Use `@upgrade-assessor` to invoke the agent directly
- Use `/upgrade-assessor.prompt` for guided workflow prompts
- Use `/upgrade-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UPGRADE_ASSE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `UPGRADE_ASSE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `UPGRADE_ASSE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `UPGRADE_ASSE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `UPGRADE_ASSE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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