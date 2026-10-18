# Incident Responder -- Workspace Configuration

## Overview
This workspace includes the **Incident Responder** agent. Use when detecting incidents, triaging alerts, resolving production issues, or performing root cause analysis on system failures.

## Agent Invocation
- Use `@incident-responder` to invoke the agent directly
- Use `/incident-responder.prompt` for guided workflow prompts
- Use `/incident-responder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INCIDENT_RES_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `INCIDENT_RES_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `INCIDENT_RES_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `INCIDENT_RES_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `INCIDENT_RES_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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