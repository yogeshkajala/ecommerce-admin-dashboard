# Mesh Configurator -- Workspace Configuration

## Overview
This workspace includes the **Mesh Configurator** agent. Configure service mesh: Istio/Linkerd policies, mTLS, circuit breakers, retries.

## Agent Invocation
- Use `@mesh-configurator` to invoke the agent directly
- Use `/mesh-configurator.prompt` for guided workflow prompts
- Use `/mesh-configurator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MESH_CONFIGU_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MESH_CONFIGU_DRY_RUN` | `false` | Preview changes without executing |
| `MESH_CONFIGU_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MESH_CONFIGU_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MESH_CONFIGU_NOTIFY` | `true` | Send notifications on completion |

## Key Conventions
- Follow established coding standards and best practices
- Use the agent for domain-specific tasks within its scope
- Provide clear, specific context when invoking the agent
- Review agent outputs before applying changes
- Use dry-run mode for previewing changes

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations