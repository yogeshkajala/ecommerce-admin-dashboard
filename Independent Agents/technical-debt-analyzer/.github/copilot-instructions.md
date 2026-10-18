# Technical Debt Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Technical Debt Analyzer** agent. Use when analyzing technical debt in legacy systems to inform modernization scope and effort estimation.

## Agent Invocation
- Use `@technical-debt-analyzer` to invoke the agent directly
- Use `/technical-debt-analyzer.prompt` for guided workflow prompts
- Use `/technical-debt-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TECHNICAL_DE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `TECHNICAL_DE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `TECHNICAL_DE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `TECHNICAL_DE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `TECHNICAL_DE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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