# Pattern Learner -- Workspace Configuration

## Overview
This workspace includes the **Pattern Learner** agent. Learn from incident outcomes to create new symptom patterns, improve match accuracy, and expand the automated remediation knowledge base.

## Agent Invocation
- Use `@pattern-learner` to invoke the agent directly
- Use `/pattern-learner.prompt` for guided workflow prompts
- Use `/pattern-learner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PATTERN_LEAR_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `PATTERN_LEAR_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `PATTERN_LEAR_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `PATTERN_LEAR_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `PATTERN_LEAR_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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