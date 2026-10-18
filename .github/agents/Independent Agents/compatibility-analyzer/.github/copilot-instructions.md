# Compatibility Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Compatibility Analyzer** agent. Analyze compatibility between current code and target upgrade versions.

## Agent Invocation
- Use `@compatibility-analyzer` to invoke the agent directly
- Use `/compatibility-analyzer.prompt` for guided workflow prompts
- Use `/compatibility-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPATIBILIT_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `COMPATIBILIT_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `COMPATIBILIT_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `COMPATIBILIT_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `COMPATIBILIT_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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