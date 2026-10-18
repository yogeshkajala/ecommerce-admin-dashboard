# Scope Guardian -- Workspace Configuration

## Overview
This workspace includes the **Scope Guardian** agent. Use when analyzing scope change requests for impact on timeline, budget, and quality.

## Agent Invocation
- Use `@scope-guardian` to invoke the agent directly
- Use `/scope-guardian.prompt` for guided workflow prompts
- Use `/scope-guardian-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SCOPE_GUARDI_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `SCOPE_GUARDI_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `SCOPE_GUARDI_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `SCOPE_GUARDI_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `SCOPE_GUARDI_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

## Key Conventions
- Cost analysis uses configured lookback window
- Savings recommendations require minimum threshold
- Reserved instance analysis included by default
- Budget alerts trigger at configured utilization percentage
- Reports follow configured output format

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations