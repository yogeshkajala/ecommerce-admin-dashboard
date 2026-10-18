# Database Splitter -- Workspace Configuration

## Overview
This workspace includes the **Database Splitter** agent. Use when splitting shared databases into service-owned databases with data migration and synchronization.

## Agent Invocation
- Use `@database-splitter` to invoke the agent directly
- Use `/database-splitter.prompt` for guided workflow prompts
- Use `/database-splitter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATABASE_SPL_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `DATABASE_SPL_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `DATABASE_SPL_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `DATABASE_SPL_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `DATABASE_SPL_DRY_RUN` | `true` | Preview changes without executing |

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