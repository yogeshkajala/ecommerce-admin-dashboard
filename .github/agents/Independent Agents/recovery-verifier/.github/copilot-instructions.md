# Recovery Verifier -- Workspace Configuration

## Overview
This workspace includes the **Recovery Verifier** agent. Verify system recovery after remediation by checking health endpoints, comparing metrics against baselines, and confirming symptom resolution.

## Agent Invocation
- Use `@recovery-verifier` to invoke the agent directly
- Use `/recovery-verifier.prompt` for guided workflow prompts
- Use `/recovery-verifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RECOVERY_VER_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `RECOVERY_VER_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `RECOVERY_VER_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `RECOVERY_VER_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `RECOVERY_VER_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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