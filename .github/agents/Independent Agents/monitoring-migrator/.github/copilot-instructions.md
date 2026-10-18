# Monitoring Migrator -- Workspace Configuration

## Overview
This workspace includes the **Monitoring Migrator** agent. Use when migrating monitoring and alerting from legacy systems to modern observability platforms ensuring alert parity and coverage.

## Agent Invocation
- Use `@monitoring-migrator` to invoke the agent directly
- Use `/monitoring-migrator.prompt` for guided workflow prompts
- Use `/monitoring-migrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MONITORING_M_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `MONITORING_M_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `MONITORING_M_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `MONITORING_M_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `MONITORING_M_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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