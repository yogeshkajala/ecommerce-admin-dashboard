# Dependency Mapper -- Workspace Configuration

## Overview
This workspace includes the **Dependency Mapper** agent. Use when mapping workload dependencies, communication patterns, and data flows to define migration groups.

## Agent Invocation
- Use `@dependency-mapper` to invoke the agent directly
- Use `/dependency-mapper.prompt` for guided workflow prompts
- Use `/dependency-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_M_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `DEPENDENCY_M_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `DEPENDENCY_M_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `DEPENDENCY_M_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `DEPENDENCY_M_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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