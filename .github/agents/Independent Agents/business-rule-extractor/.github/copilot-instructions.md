# Business Rule Extractor -- Workspace Configuration

## Overview
This workspace includes the **Business Rule Extractor** agent. Use when extracting business rules from legacy code, stored procedures, configuration files, and documentation.

## Agent Invocation
- Use `@business-rule-extractor` to invoke the agent directly
- Use `/business-rule-extractor.prompt` for guided workflow prompts
- Use `/business-rule-extractor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUSINESS_RUL_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `BUSINESS_RUL_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `BUSINESS_RUL_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `BUSINESS_RUL_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `BUSINESS_RUL_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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