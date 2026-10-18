# Data Integrity Checker -- Workspace Configuration

## Overview
This workspace includes the **Data Integrity Checker** agent. Use when verifying data integrity after migration -- row counts, checksums, referential integrity, and sample validation.

## Agent Invocation
- Use `@data-integrity-checker` to invoke the agent directly
- Use `/data-integrity-checker.prompt` for guided workflow prompts
- Use `/data-integrity-checker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_INTEGRI_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `DATA_INTEGRI_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `DATA_INTEGRI_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `DATA_INTEGRI_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `DATA_INTEGRI_DRY_RUN` | `true` | Preview changes without executing |

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