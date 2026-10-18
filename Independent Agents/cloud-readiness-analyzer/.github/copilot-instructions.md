# Cloud Readiness Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Cloud Readiness Analyzer** agent. Use when analyzing application cloud readiness against 12-Factor App principles and cloud-native maturity model.

## Agent Invocation
- Use `@cloud-readiness-analyzer` to invoke the agent directly
- Use `/cloud-readiness-analyzer.prompt` for guided workflow prompts
- Use `/cloud-readiness-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CLOUD_READIN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CLOUD_READIN_DRY_RUN` | `false` | Preview changes without executing |
| `CLOUD_READIN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CLOUD_READIN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CLOUD_READIN_NOTIFY` | `true` | Send notifications on completion |

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