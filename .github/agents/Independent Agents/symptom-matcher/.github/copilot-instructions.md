# Symptom Matcher -- Workspace Configuration

## Overview
This workspace includes the **Symptom Matcher** agent. Match observed symptoms (alerts, metrics anomalies, error patterns) against a knowledge base of known issue patterns to recommend remediation actions.

## Agent Invocation
- Use `@symptom-matcher` to invoke the agent directly
- Use `/symptom-matcher.prompt` for guided workflow prompts
- Use `/symptom-matcher-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SYMPTOM_MATC_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `SYMPTOM_MATC_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `SYMPTOM_MATC_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `SYMPTOM_MATC_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `SYMPTOM_MATC_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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