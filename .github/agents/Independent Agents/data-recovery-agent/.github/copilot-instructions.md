# Data Recovery Agent -- Workspace Configuration

## Overview
This workspace includes the **Data Recovery Agent** agent. Use when recovering data changes made between the pre-upgrade snapshot and the rollback point.

## Agent Invocation
- Use `@data-recovery-agent` to invoke the agent directly
- Use `/data-recovery-agent.prompt` for guided workflow prompts
- Use `/data-recovery-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_RECOVER_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `DATA_RECOVER_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `DATA_RECOVER_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `DATA_RECOVER_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `DATA_RECOVER_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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