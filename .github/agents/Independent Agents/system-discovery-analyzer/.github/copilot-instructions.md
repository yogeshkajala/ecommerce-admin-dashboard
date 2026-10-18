# System Discovery Analyzer -- Workspace Configuration

## Overview
This workspace includes the **System Discovery Analyzer** agent. Discover systems, services, APIs, databases, integrations, and external dependencies in a codebase.

## Agent Invocation
- Use `@system-discovery-analyzer` to invoke the agent directly
- Use `/system-discovery-analyzer.prompt` for guided workflow prompts
- Use `/system-discovery-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SYSTEM_DISCO_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `SYSTEM_DISCO_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `SYSTEM_DISCO_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `SYSTEM_DISCO_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `SYSTEM_DISCO_DRY_RUN` | `true` | Preview changes without executing |

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