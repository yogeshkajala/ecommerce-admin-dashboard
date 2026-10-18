# Oncall Setup Agent -- Workspace Configuration

## Overview
This workspace includes the **Oncall Setup Agent** agent. Use when configuring on-call rotations, escalation policies, paging rules, and incident response tooling for production support.

## Agent Invocation
- Use `@oncall-setup-agent` to invoke the agent directly
- Use `/oncall-setup-agent.prompt` for guided workflow prompts
- Use `/oncall-setup-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ONCALL_SETUP_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `ONCALL_SETUP_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `ONCALL_SETUP_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `ONCALL_SETUP_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `ONCALL_SETUP_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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