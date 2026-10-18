# Budget Tracker -- Workspace Configuration

## Overview
This workspace includes the **Budget Tracker** agent. Use when tracking project budgets including spend monitoring, variance analysis, and financial forecasting.

## Agent Invocation
- Use `@budget-tracker` to invoke the agent directly
- Use `/budget-tracker.prompt` for guided workflow prompts
- Use `/budget-tracker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUDGET_TRACK_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `BUDGET_TRACK_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `BUDGET_TRACK_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `BUDGET_TRACK_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `BUDGET_TRACK_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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