# Severity Classifier -- Workspace Configuration

## Overview
This workspace includes the **Severity Classifier** agent. Classify incident severity based on impact, urgency, and affected scope.

## Agent Invocation
- Use `@severity-classifier` to invoke the agent directly
- Use `/severity-classifier.prompt` for guided workflow prompts
- Use `/severity-classifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SEVERITY_CLA_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `SEVERITY_CLA_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `SEVERITY_CLA_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `SEVERITY_CLA_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `SEVERITY_CLA_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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