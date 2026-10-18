# Spreadsheet Creator -- Workspace Configuration

## Overview
This workspace includes the **Spreadsheet Creator** agent. Use when generating Excel (XLSX) spreadsheets with formatted tables, charts, formulas, conditional formatting, and data validation using openpyxl.

## Agent Invocation
- Use `@spreadsheet-creator` to invoke the agent directly
- Use `/spreadsheet-creator.prompt` for guided workflow prompts
- Use `/spreadsheet-creator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SPREADSHEET__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SPREADSHEET__DRY_RUN` | `false` | Preview changes without executing |
| `SPREADSHEET__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SPREADSHEET__TIMEOUT` | `300` | Maximum execution time in seconds |
| `SPREADSHEET__NOTIFY` | `true` | Send notifications on completion |

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