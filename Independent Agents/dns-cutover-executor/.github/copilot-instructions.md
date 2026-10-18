# Dns Cutover Executor -- Workspace Configuration

## Overview
This workspace includes the **Dns Cutover Executor** agent. Use when executing DNS cutover, traffic shifting, and load balancer reconfiguration during migration cutover windows.

## Agent Invocation
- Use `@dns-cutover-executor` to invoke the agent directly
- Use `/dns-cutover-executor.prompt` for guided workflow prompts
- Use `/dns-cutover-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DNS_CUTOVER__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `DNS_CUTOVER__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `DNS_CUTOVER__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `DNS_CUTOVER__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `DNS_CUTOVER__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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