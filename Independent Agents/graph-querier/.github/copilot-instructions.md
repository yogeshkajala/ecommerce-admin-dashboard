# Graph Querier -- Workspace Configuration

## Overview
This workspace includes the **Graph Querier** agent. Query the operational knowledge graph for dependency analysis, impact assessment, path finding, and operational insights.

## Agent Invocation
- Use `@graph-querier` to invoke the agent directly
- Use `/graph-querier.prompt` for guided workflow prompts
- Use `/graph-querier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `GRAPH_QUERIE_BACKUP_BEFORE` | `true` | Take backup before any schema change |
| `GRAPH_QUERIE_SLOW_QUERY_MS` | `2000` | Threshold for slow query detection in milliseconds |
| `GRAPH_QUERIE_MAX_LOCK_WAIT` | `30` | Maximum lock wait time in seconds |
| `GRAPH_QUERIE_INDEX_ANALYSIS` | `true` | Auto-analyze index usage and recommendations |
| `GRAPH_QUERIE_DRY_RUN` | `true` | Preview changes without executing |

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