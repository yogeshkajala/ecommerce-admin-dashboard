# Data Ownership Planner -- Workspace Configuration

## Overview
This workspace includes the **Data Ownership Planner** agent. Use when planning data ownership including database-per-service, data replication, and eventual consistency patterns.

## Agent Invocation
- Use `@data-ownership-planner` to invoke the agent directly
- Use `/data-ownership-planner.prompt` for guided workflow prompts
- Use `/data-ownership-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_OWNERSH_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `DATA_OWNERSH_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `DATA_OWNERSH_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `DATA_OWNERSH_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `DATA_OWNERSH_DRY_RUN` | `true` | Preview changes without executing |

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