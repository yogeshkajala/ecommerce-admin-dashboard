# Knowledge Retriever -- Workspace Configuration

## Overview
This workspace includes the **Knowledge Retriever** agent. Retrieve contextual knowledge from the knowledge graph and operational documents to support incident response and operational decisions.

## Agent Invocation
- Use `@knowledge-retriever` to invoke the agent directly
- Use `/knowledge-retriever.prompt` for guided workflow prompts
- Use `/knowledge-retriever-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `KNOWLEDGE_RE_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `KNOWLEDGE_RE_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `KNOWLEDGE_RE_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `KNOWLEDGE_RE_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `KNOWLEDGE_RE_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

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