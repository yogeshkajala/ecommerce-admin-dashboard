# Knowledge Transfer Agent -- Workspace Configuration

## Overview
This workspace includes the **Knowledge Transfer Agent** agent. Use when managing knowledge transfer from legacy system experts including documentation capture, training programs, and tribal knowledge preservation.

## Agent Invocation
- Use `@knowledge-transfer-agent` to invoke the agent directly
- Use `/knowledge-transfer-agent.prompt` for guided workflow prompts
- Use `/knowledge-transfer-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `KNOWLEDGE_TR_STRATEGY` | `rehost` | Default migration strategy: rehost, replatform, refactor, retire |
| `KNOWLEDGE_TR_DOWNTIME_MAX` | `4h` | Maximum acceptable downtime window |
| `KNOWLEDGE_TR_DATA_VALIDATION` | `checksum` | Data validation method: checksum, row-count, full-compare |
| `KNOWLEDGE_TR_ROLLBACK_WINDOW` | `72h` | Time window for rollback after cutover |
| `KNOWLEDGE_TR_PARALLEL_STREAMS` | `4` | Number of parallel migration streams |

## Key Conventions
- All migrations require rollback plan before execution
- Data validation is mandatory post-migration
- Maximum downtime window must not be exceeded
- Parallel migration streams follow configured limit
- Legacy and target systems run in parallel during validation

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations