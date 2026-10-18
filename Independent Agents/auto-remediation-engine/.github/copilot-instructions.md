# Auto Remediation Engine -- Workspace Configuration

## Overview
This workspace includes the **Auto Remediation Engine** agent. Use when detecting and automatically fixing system failures, validating recovery, or recommending proactive optimizations.

## Agent Invocation
- Use `@auto-remediation-engine` to invoke the agent directly
- Use `/auto-remediation-engine.prompt` for guided workflow prompts
- Use `/auto-remediation-engine-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AUTO_REMEDIA_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `AUTO_REMEDIA_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `AUTO_REMEDIA_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `AUTO_REMEDIA_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `AUTO_REMEDIA_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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