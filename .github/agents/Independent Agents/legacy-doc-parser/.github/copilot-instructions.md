# Legacy Doc Parser -- Workspace Configuration

## Overview
This workspace includes the **Legacy Doc Parser** agent. Use when parsing legacy documentation, runbooks, and wikis to extract technical requirements and system behavior.

## Agent Invocation
- Use `@legacy-doc-parser` to invoke the agent directly
- Use `/legacy-doc-parser.prompt` for guided workflow prompts
- Use `/legacy-doc-parser-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `LEGACY_DOC_P_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `LEGACY_DOC_P_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `LEGACY_DOC_P_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `LEGACY_DOC_P_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `LEGACY_DOC_P_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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