# Performance Benchmark -- Workspace Configuration

## Overview
This workspace includes the **Performance Benchmark** agent. Use when benchmarking modern system performance against legacy baseline for equivalent workloads.

## Agent Invocation
- Use `@performance-benchmark` to invoke the agent directly
- Use `/performance-benchmark.prompt` for guided workflow prompts
- Use `/performance-benchmark-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PERFORMANCE__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `PERFORMANCE__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `PERFORMANCE__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `PERFORMANCE__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `PERFORMANCE__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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