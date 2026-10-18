# Cost Efficiency Validator -- Workspace Configuration

## Overview
This workspace includes the **Cost Efficiency Validator** agent. Use when validating that modernized application meets cost efficiency targets compared to pre-modernization baseline.

## Agent Invocation
- Use `@cost-efficiency-validator` to invoke the agent directly
- Use `/cost-efficiency-validator.prompt` for guided workflow prompts
- Use `/cost-efficiency-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COST_EFFICIE_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `COST_EFFICIE_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `COST_EFFICIE_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `COST_EFFICIE_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `COST_EFFICIE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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