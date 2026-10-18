# Impact Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Impact Analyzer** agent. Use when analyzing codebase impact of proposed changes including dependency mapping, risk assessment, and effort estimation.

## Agent Invocation
- Use `@impact-analyzer` to invoke the agent directly
- Use `/impact-analyzer.prompt` for guided workflow prompts
- Use `/impact-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `IMPACT_ANALY_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `IMPACT_ANALY_DRY_RUN` | `false` | Preview changes without executing |
| `IMPACT_ANALY_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `IMPACT_ANALY_TIMEOUT` | `300` | Maximum execution time in seconds |
| `IMPACT_ANALY_NOTIFY` | `true` | Send notifications on completion |

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