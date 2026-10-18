# Runbook Developer -- Workspace Configuration

## Overview
This workspace includes the **Runbook Developer** agent. Use when creating operational runbooks including incident response procedures, troubleshooting guides, and maintenance playbooks for new applications.

## Agent Invocation
- Use `@runbook-developer` to invoke the agent directly
- Use `/runbook-developer.prompt` for guided workflow prompts
- Use `/runbook-developer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RUNBOOK_DEVE_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `RUNBOOK_DEVE_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `RUNBOOK_DEVE_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `RUNBOOK_DEVE_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `RUNBOOK_DEVE_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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