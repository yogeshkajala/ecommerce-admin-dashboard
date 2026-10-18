# Documentation Updater -- Workspace Configuration

## Overview
This workspace includes the **Documentation Updater** agent. Use when updating operational documentation, runbooks, and architecture diagrams after migration.

## Agent Invocation
- Use `@documentation-updater` to invoke the agent directly
- Use `/documentation-updater.prompt` for guided workflow prompts
- Use `/documentation-updater-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DOCUMENTATIO_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `DOCUMENTATIO_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `DOCUMENTATIO_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `DOCUMENTATIO_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `DOCUMENTATIO_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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