# Utilization Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Utilization Analyzer** agent. Analyze resource utilization across compute, memory, storage, and network to identify waste, bottlenecks, and right-sizing opportunities.

## Agent Invocation
- Use `@utilization-analyzer` to invoke the agent directly
- Use `/utilization-analyzer.prompt` for guided workflow prompts
- Use `/utilization-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UTILIZATION__BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `UTILIZATION__ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `UTILIZATION__SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `UTILIZATION__INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `UTILIZATION__REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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