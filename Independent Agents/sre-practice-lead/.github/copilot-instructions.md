# Sre Practice Lead -- Workspace Configuration

## Overview
This workspace includes the **Sre Practice Lead** agent. Use when implementing SRE practices including SLO definition, error budget management, reliability reviews, and chaos engineering for new projects.

## Agent Invocation
- Use `@sre-practice-lead` to invoke the agent directly
- Use `/sre-practice-lead.prompt` for guided workflow prompts
- Use `/sre-practice-lead-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SRE_PRACTICE_ERROR_BUDGET` | `0.1` | Error budget percentage (0.0-1.0) |
| `SRE_PRACTICE_SLO_TARGET` | `99.9` | Default SLO target percentage |
| `SRE_PRACTICE_CHAOS_ENABLED` | `false` | Enable chaos engineering experiments |
| `SRE_PRACTICE_RUNBOOK_AUTO` | `true` | Auto-execute runbooks for known issues |
| `SRE_PRACTICE_BLAST_RADIUS_MAX` | `10` | Maximum blast radius percentage for chaos |

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