# Code Migrator -- Workspace Configuration

## Overview
This workspace includes the **Code Migrator** agent. Use when applying code migrations for breaking API changes using codemods and manual fixes.

## Agent Invocation
- Use `@code-migrator` to invoke the agent directly
- Use `/code-migrator.prompt` for guided workflow prompts
- Use `/code-migrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_MIGRATO_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `CODE_MIGRATO_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `CODE_MIGRATO_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `CODE_MIGRATO_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `CODE_MIGRATO_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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