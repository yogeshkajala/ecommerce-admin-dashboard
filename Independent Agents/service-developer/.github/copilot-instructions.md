# Service Developer -- Workspace Configuration

## Overview
This workspace includes the **Service Developer** agent. Use when extracting services from monolith including code extraction, database splitting, event bus integration, and service mesh setup.

## Agent Invocation
- Use `@service-developer` to invoke the agent directly
- Use `/service-developer.prompt` for guided workflow prompts
- Use `/service-developer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_DEVE_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `SERVICE_DEVE_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `SERVICE_DEVE_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `SERVICE_DEVE_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `SERVICE_DEVE_DRY_RUN` | `true` | Preview changes without executing |

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