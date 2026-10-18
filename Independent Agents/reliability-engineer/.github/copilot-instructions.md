# Reliability Engineer -- Workspace Configuration

## Overview
This workspace includes the **Reliability Engineer** agent. Use when executing runbooks, monitoring SLOs, planning capacity, or conducting chaos engineering for reliability improvement.

## Agent Invocation
- Use `@reliability-engineer` to invoke the agent directly
- Use `/reliability-engineer.prompt` for guided workflow prompts
- Use `/reliability-engineer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RELIABILITY__ERROR_BUDGET` | `0.1` | Error budget percentage (0.0-1.0) |
| `RELIABILITY__SLO_TARGET` | `99.9` | Default SLO target percentage |
| `RELIABILITY__CHAOS_ENABLED` | `false` | Enable chaos engineering experiments |
| `RELIABILITY__RUNBOOK_AUTO` | `true` | Auto-execute runbooks for known issues |
| `RELIABILITY__BLAST_RADIUS_MAX` | `10` | Maximum blast radius percentage for chaos |

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