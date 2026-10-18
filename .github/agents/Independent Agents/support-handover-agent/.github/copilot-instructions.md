# Support Handover Agent -- Workspace Configuration

## Overview
This workspace includes the **Support Handover Agent** agent. Use when transitioning support processes from legacy to modernized systems including runbook updates, escalation paths, and support team certification.

## Agent Invocation
- Use `@support-handover-agent` to invoke the agent directly
- Use `/support-handover-agent.prompt` for guided workflow prompts
- Use `/support-handover-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SUPPORT_HAND_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `SUPPORT_HAND_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `SUPPORT_HAND_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `SUPPORT_HAND_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `SUPPORT_HAND_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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