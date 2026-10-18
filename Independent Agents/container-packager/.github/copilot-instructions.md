# Container Packager -- Workspace Configuration

## Overview
This workspace includes the **Container Packager** agent. Use when creating Dockerfiles, container images, and Kubernetes manifests for modernized services.

## Agent Invocation
- Use `@container-packager` to invoke the agent directly
- Use `/container-packager.prompt` for guided workflow prompts
- Use `/container-packager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTAINER_PA_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `CONTAINER_PA_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `CONTAINER_PA_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `CONTAINER_PA_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `CONTAINER_PA_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

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