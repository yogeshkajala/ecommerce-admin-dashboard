# Workload Discovery -- Workspace Configuration

## Overview
This workspace includes the **Workload Discovery** agent. Use when discovering and inventorying workloads, servers, databases, and network dependencies for migration assessment.

## Agent Invocation
- Use `@workload-discovery` to invoke the agent directly
- Use `/workload-discovery.prompt` for guided workflow prompts
- Use `/workload-discovery-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `WORKLOAD_DIS_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `WORKLOAD_DIS_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `WORKLOAD_DIS_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `WORKLOAD_DIS_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `WORKLOAD_DIS_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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