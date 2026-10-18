# Escalation Manager -- Workspace Configuration

## Overview
This workspace includes the **Escalation Manager** agent. Manage escalation paths, notifications, and stakeholder communication.

## Agent Invocation
- Use `@escalation-manager` to invoke the agent directly
- Use `/escalation-manager.prompt` for guided workflow prompts
- Use `/escalation-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ESCALATION_M_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `ESCALATION_M_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `ESCALATION_M_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `ESCALATION_M_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `ESCALATION_M_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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