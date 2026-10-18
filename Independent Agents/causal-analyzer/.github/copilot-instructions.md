# Causal Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Causal Analyzer** agent. Determine root cause of incidents using systematic causal analysis.

## Agent Invocation
- Use `@causal-analyzer` to invoke the agent directly
- Use `/causal-analyzer.prompt` for guided workflow prompts
- Use `/causal-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CAUSAL_ANALY_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `CAUSAL_ANALY_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `CAUSAL_ANALY_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `CAUSAL_ANALY_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `CAUSAL_ANALY_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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