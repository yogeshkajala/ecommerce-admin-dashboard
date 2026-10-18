# Root Cause Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Root Cause Analyzer** agent. Use when performing root cause analysis on resolved incidents, building incident timelines, or generating preventive action items.

## Agent Invocation
- Use `@root-cause-analyzer` to invoke the agent directly
- Use `/root-cause-analyzer.prompt` for guided workflow prompts
- Use `/root-cause-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROOT_CAUSE_A_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `ROOT_CAUSE_A_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `ROOT_CAUSE_A_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `ROOT_CAUSE_A_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `ROOT_CAUSE_A_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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