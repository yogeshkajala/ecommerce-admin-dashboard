# Evidence Grounder -- Workspace Configuration

## Overview
This workspace includes the **Evidence Grounder** agent. Use when ensuring AI outputs are grounded in retrievable evidence, adding citations to claims, mapping assertions to source documents, or detecting ungrounded statements.

## Agent Invocation
- Use `@evidence-grounder` to invoke the agent directly
- Use `/evidence-grounder.prompt` for guided workflow prompts
- Use `/evidence-grounder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EVIDENCE_GRO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EVIDENCE_GRO_DRY_RUN` | `false` | Preview changes without executing |
| `EVIDENCE_GRO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EVIDENCE_GRO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EVIDENCE_GRO_NOTIFY` | `true` | Send notifications on completion |

## Key Conventions
- Follow established coding standards and best practices
- Use the agent for domain-specific tasks within its scope
- Provide clear, specific context when invoking the agent
- Review agent outputs before applying changes
- Use dry-run mode for previewing changes

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations