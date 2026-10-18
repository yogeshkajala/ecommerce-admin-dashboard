# Incident Playbook Writer -- Workspace Configuration

## Overview
This workspace includes the **Incident Playbook Writer** agent. Use when writing incident response playbooks and runbooks for modernized cloud application failure modes.

## Agent Invocation
- Use `@incident-playbook-writer` to invoke the agent directly
- Use `/incident-playbook-writer.prompt` for guided workflow prompts
- Use `/incident-playbook-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INCIDENT_PLA_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `INCIDENT_PLA_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `INCIDENT_PLA_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `INCIDENT_PLA_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `INCIDENT_PLA_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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