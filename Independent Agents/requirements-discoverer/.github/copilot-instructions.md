# Requirements Discoverer -- Workspace Configuration

## Overview
This workspace includes the **Requirements Discoverer** agent. Use when discovering and documenting modernization requirements from stakeholders and legacy systems before analysis begins.

## Agent Invocation
- Use `@requirements-discoverer` to invoke the agent directly
- Use `/requirements-discoverer.prompt` for guided workflow prompts
- Use `/requirements-discoverer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REQUIREMENTS_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `REQUIREMENTS_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `REQUIREMENTS_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `REQUIREMENTS_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `REQUIREMENTS_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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