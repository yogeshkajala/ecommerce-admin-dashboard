# Jira Ops Manager -- Workspace Configuration

## Overview
This workspace includes the **Jira Ops Manager** agent. Use when creating Jira dashboards, planning sprints, managing work items, enriching tickets, or performing bulk Jira operations. Covers full Jira operational lifecycle.

## Agent Invocation
- Use `@jira-ops-manager` to invoke the agent directly
- Use `/jira-ops-manager.prompt` for guided workflow prompts
- Use `/jira-ops-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `JIRA_OPS_MAN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `JIRA_OPS_MAN_DRY_RUN` | `false` | Preview changes without executing |
| `JIRA_OPS_MAN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `JIRA_OPS_MAN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `JIRA_OPS_MAN_NOTIFY` | `true` | Send notifications on completion |

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