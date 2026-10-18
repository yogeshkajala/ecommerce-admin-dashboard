# Chaos Engineer -- Workspace Configuration

## Overview
This workspace includes the **Chaos Engineer** agent. Execute chaos experiments: pod kill, network partition, latency injection.

## Agent Invocation
- Use `@chaos-engineer` to invoke the agent directly
- Use `/chaos-engineer.prompt` for guided workflow prompts
- Use `/chaos-engineer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CHAOS_ENGINE_ERROR_BUDGET` | `0.1` | Error budget percentage (0.0-1.0) |
| `CHAOS_ENGINE_SLO_TARGET` | `99.9` | Default SLO target percentage |
| `CHAOS_ENGINE_CHAOS_ENABLED` | `false` | Enable chaos engineering experiments |
| `CHAOS_ENGINE_RUNBOOK_AUTO` | `true` | Auto-execute runbooks for known issues |
| `CHAOS_ENGINE_BLAST_RADIUS_MAX` | `10` | Maximum blast radius percentage for chaos |

## Key Conventions
- Error budgets are tracked against configured target
- SLO targets follow configured percentage
- Chaos experiments disabled by default (opt-in)
- Runbooks auto-execute for known issue patterns
- Blast radius is limited to configured maximum

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations