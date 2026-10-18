# Timeline Builder -- Workspace Configuration

## Overview
This workspace includes the **Timeline Builder** agent. Build chronological incident timeline from all evidence sources.

## Agent Invocation
- Use `@timeline-builder` to invoke the agent directly
- Use `/timeline-builder.prompt` for guided workflow prompts
- Use `/timeline-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TIMELINE_BUI_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `TIMELINE_BUI_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `TIMELINE_BUI_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `TIMELINE_BUI_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `TIMELINE_BUI_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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