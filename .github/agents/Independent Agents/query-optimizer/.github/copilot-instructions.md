# Query Optimizer -- Workspace Configuration

## Overview
This workspace includes the **Query Optimizer** agent. Analyze slow database queries, review execution plans, recommend index changes, and optimize query performance.

## Agent Invocation
- Use `@query-optimizer` to invoke the agent directly
- Use `/query-optimizer.prompt` for guided workflow prompts
- Use `/query-optimizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `QUERY_OPTIMI_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `QUERY_OPTIMI_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `QUERY_OPTIMI_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `QUERY_OPTIMI_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `QUERY_OPTIMI_DRY_RUN` | `true` | Preview changes without executing |

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