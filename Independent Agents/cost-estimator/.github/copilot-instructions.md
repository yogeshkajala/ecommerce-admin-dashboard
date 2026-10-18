# Cost Estimator -- Workspace Configuration

## Overview
This workspace includes the **Cost Estimator** agent. Use when estimating migration costs, cloud run-rate, and total cost of ownership for cloud migration.

## Agent Invocation
- Use `@cost-estimator` to invoke the agent directly
- Use `/cost-estimator.prompt` for guided workflow prompts
- Use `/cost-estimator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COST_ESTIMAT_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `COST_ESTIMAT_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `COST_ESTIMAT_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `COST_ESTIMAT_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `COST_ESTIMAT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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