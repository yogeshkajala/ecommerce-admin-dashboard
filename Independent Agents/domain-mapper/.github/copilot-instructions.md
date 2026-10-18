# Domain Mapper -- Workspace Configuration

## Overview
This workspace includes the **Domain Mapper** agent. Map legacy modules to domain boundaries in target architecture.

## Agent Invocation
- Use `@domain-mapper` to invoke the agent directly
- Use `/domain-mapper.prompt` for guided workflow prompts
- Use `/domain-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DOMAIN_MAPPE_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `DOMAIN_MAPPE_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `DOMAIN_MAPPE_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `DOMAIN_MAPPE_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `DOMAIN_MAPPE_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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