# Cost Optimizer Agent -- Workspace Configuration

## Overview
This workspace includes the **Cost Optimizer Agent** agent. Use when analyzing cloud costs, identifying waste, and recommending right-sizing and savings after migration.

## Agent Invocation
- Use `@cost-optimizer-agent` to invoke the agent directly
- Use `/cost-optimizer-agent.prompt` for guided workflow prompts
- Use `/cost-optimizer-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COST_OPTIMIZ_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `COST_OPTIMIZ_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `COST_OPTIMIZ_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `COST_OPTIMIZ_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `COST_OPTIMIZ_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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