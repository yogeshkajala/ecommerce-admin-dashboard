# Recovery Validator -- Workspace Configuration

## Overview
This workspace includes the **Recovery Validator** agent. Use when validating that an applied fix restored healthy operational state, checking service health, and confirming SLI recovery.

## Agent Invocation
- Use `@recovery-validator` to invoke the agent directly
- Use `/recovery-validator.prompt` for guided workflow prompts
- Use `/recovery-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RECOVERY_VAL_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `RECOVERY_VAL_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `RECOVERY_VAL_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `RECOVERY_VAL_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `RECOVERY_VAL_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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