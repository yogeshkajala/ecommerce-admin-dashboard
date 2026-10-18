# Coexistence Designer -- Workspace Configuration

## Overview
This workspace includes the **Coexistence Designer** agent. Use when designing coexistence patterns (strangler fig, parallel run) for incremental legacy migration.

## Agent Invocation
- Use `@coexistence-designer` to invoke the agent directly
- Use `/coexistence-designer.prompt` for guided workflow prompts
- Use `/coexistence-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COEXISTENCE__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `COEXISTENCE__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `COEXISTENCE__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `COEXISTENCE__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `COEXISTENCE__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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