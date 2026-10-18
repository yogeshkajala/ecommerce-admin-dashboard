# Workload Discoverer -- Workspace Configuration

## Overview
This workspace includes the **Workload Discoverer** agent. Discover and inventory workloads: servers, databases, dependencies, traffic patterns.

## Agent Invocation
- Use `@workload-discoverer` to invoke the agent directly
- Use `/workload-discoverer.prompt` for guided workflow prompts
- Use `/workload-discoverer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `WORKLOAD_DIS_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `WORKLOAD_DIS_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `WORKLOAD_DIS_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `WORKLOAD_DIS_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `WORKLOAD_DIS_DRY_RUN` | `true` | Preview changes without executing |

## Key Conventions
- Backup required before any schema change
- Slow queries are flagged above configured threshold
- Lock wait times must not exceed configured maximum
- Index analysis runs automatically on schema changes
- Dry-run mode previews changes before execution

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations