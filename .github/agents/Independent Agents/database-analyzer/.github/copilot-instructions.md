# Database Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Database Analyzer** agent. Analyze shared database: table ownership, cross-domain joins, write patterns.

## Agent Invocation
- Use `@database-analyzer` to invoke the agent directly
- Use `/database-analyzer.prompt` for guided workflow prompts
- Use `/database-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATABASE_ANA_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `DATABASE_ANA_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `DATABASE_ANA_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `DATABASE_ANA_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `DATABASE_ANA_DRY_RUN` | `true` | Preview changes without executing |

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