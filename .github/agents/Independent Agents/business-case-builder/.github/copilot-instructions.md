# Business Case Builder -- Workspace Configuration

## Overview
This workspace includes the **Business Case Builder** agent. Use when building the financial business case for cloud modernization including ROI, TCO, and risk analysis.

## Agent Invocation
- Use `@business-case-builder` to invoke the agent directly
- Use `/business-case-builder.prompt` for guided workflow prompts
- Use `/business-case-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUSINESS_CAS_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `BUSINESS_CAS_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `BUSINESS_CAS_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `BUSINESS_CAS_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `BUSINESS_CAS_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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