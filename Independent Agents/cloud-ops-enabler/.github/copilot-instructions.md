# Cloud Ops Enabler -- Workspace Configuration

## Overview
This workspace includes the **Cloud Ops Enabler** agent. Use when enabling cloud operations for modernized applications including observability, auto-scaling, backup strategies, and incident playbooks.

## Agent Invocation
- Use `@cloud-ops-enabler` to invoke the agent directly
- Use `/cloud-ops-enabler.prompt` for guided workflow prompts
- Use `/cloud-ops-enabler-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CLOUD_OPS_EN_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `CLOUD_OPS_EN_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `CLOUD_OPS_EN_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `CLOUD_OPS_EN_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `CLOUD_OPS_EN_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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