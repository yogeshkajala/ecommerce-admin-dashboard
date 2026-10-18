# Hotspot Detector -- Workspace Configuration

## Overview
This workspace includes the **Hotspot Detector** agent. Use when detecting change hotspots (frequently modified files), complexity hotspots, and high-risk modules for extraction prioritization.

## Agent Invocation
- Use `@hotspot-detector` to invoke the agent directly
- Use `/hotspot-detector.prompt` for guided workflow prompts
- Use `/hotspot-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `HOTSPOT_DETE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `HOTSPOT_DETE_DRY_RUN` | `false` | Preview changes without executing |
| `HOTSPOT_DETE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `HOTSPOT_DETE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `HOTSPOT_DETE_NOTIFY` | `true` | Send notifications on completion |

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