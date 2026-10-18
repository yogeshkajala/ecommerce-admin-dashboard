# Path Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Path Analyzer** agent. Analyze optimal upgrade path: direct vs incremental version jumps.

## Agent Invocation
- Use `@path-analyzer` to invoke the agent directly
- Use `/path-analyzer.prompt` for guided workflow prompts
- Use `/path-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PATH_ANALYZE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `PATH_ANALYZE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `PATH_ANALYZE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `PATH_ANALYZE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `PATH_ANALYZE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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