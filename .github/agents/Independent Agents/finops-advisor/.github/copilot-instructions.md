# Finops Advisor -- Workspace Configuration

## Overview
This workspace includes the **Finops Advisor** agent. Use when optimizing cloud costs, right-sizing resources, detecting waste, or recommending savings plans.

## Agent Invocation
- Use `@finops-advisor` to invoke the agent directly
- Use `/finops-advisor.prompt` for guided workflow prompts
- Use `/finops-advisor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FINOPS_ADVIS_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `FINOPS_ADVIS_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `FINOPS_ADVIS_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `FINOPS_ADVIS_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `FINOPS_ADVIS_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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