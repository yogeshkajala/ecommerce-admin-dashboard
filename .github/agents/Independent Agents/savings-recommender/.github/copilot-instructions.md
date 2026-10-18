# Savings Recommender -- Workspace Configuration

## Overview
This workspace includes the **Savings Recommender** agent. Use when evaluating reserved instances, savings plans, spot instance opportunities, or other long-term cost reduction strategies.

## Agent Invocation
- Use `@savings-recommender` to invoke the agent directly
- Use `/savings-recommender.prompt` for guided workflow prompts
- Use `/savings-recommender-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SAVINGS_RECO_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `SAVINGS_RECO_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `SAVINGS_RECO_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `SAVINGS_RECO_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `SAVINGS_RECO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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