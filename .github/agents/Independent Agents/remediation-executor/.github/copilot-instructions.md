# Remediation Executor -- Workspace Configuration

## Overview
This workspace includes the **Remediation Executor** agent. Execute automated remediation actions including service restarts, scaling, rollbacks, and configuration fixes with safety guardrails.

## Agent Invocation
- Use `@remediation-executor` to invoke the agent directly
- Use `/remediation-executor.prompt` for guided workflow prompts
- Use `/remediation-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REMEDIATION__AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `REMEDIATION__CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `REMEDIATION__POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `REMEDIATION__NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `REMEDIATION__RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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