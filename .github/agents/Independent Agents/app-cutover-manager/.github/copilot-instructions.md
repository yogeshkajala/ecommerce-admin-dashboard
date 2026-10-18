# App Cutover Manager -- Workspace Configuration

## Overview
This workspace includes the **App Cutover Manager** agent. Manage application cutover: stop source, final sync, start target, verify.

## Agent Invocation
- Use `@app-cutover-manager` to invoke the agent directly
- Use `/app-cutover-manager.prompt` for guided workflow prompts
- Use `/app-cutover-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `APP_CUTOVER__STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `APP_CUTOVER__DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `APP_CUTOVER__DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `APP_CUTOVER__ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `APP_CUTOVER__PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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