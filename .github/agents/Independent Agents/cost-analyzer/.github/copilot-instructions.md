# Cost Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Cost Analyzer** agent. Use when analyzing cloud spending patterns, tracking budgets, detecting cost anomalies, or generating cost allocation reports.

## Agent Invocation
- Use `@cost-analyzer` to invoke the agent directly
- Use `/cost-analyzer.prompt` for guided workflow prompts
- Use `/cost-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COST_ANALYZE_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `COST_ANALYZE_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `COST_ANALYZE_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `COST_ANALYZE_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `COST_ANALYZE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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