# Ops Enablement Lead -- Workspace Configuration

## Overview
This workspace includes the **Ops Enablement Lead** agent. Use when enabling production operations including observability setup, SRE practices, runbook creation, and on-call configuration for new projects.

## Agent Invocation
- Use `@ops-enablement-lead` to invoke the agent directly
- Use `/ops-enablement-lead.prompt` for guided workflow prompts
- Use `/ops-enablement-lead-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `OPS_ENABLEME_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `OPS_ENABLEME_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `OPS_ENABLEME_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `OPS_ENABLEME_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `OPS_ENABLEME_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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