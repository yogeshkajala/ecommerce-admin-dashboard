# Ops Readiness Checker -- Workspace Configuration

## Overview
This workspace includes the **Ops Readiness Checker** agent. Use when verifying operational readiness -- monitoring, alerting, runbooks, and capacity -- before modernized services go live.

## Agent Invocation
- Use `@ops-readiness-checker` to invoke the agent directly
- Use `/ops-readiness-checker.prompt` for guided workflow prompts
- Use `/ops-readiness-checker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `OPS_READINES_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `OPS_READINES_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `OPS_READINES_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `OPS_READINES_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `OPS_READINES_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

## Key Conventions
- SEV1/SEV2 incidents auto-escalate to on-call
- All incidents generate a postmortem template
- Alert correlation uses configured time window
- Root cause analysis follows the 5-whys methodology
- Stakeholders are notified on severity changes

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations