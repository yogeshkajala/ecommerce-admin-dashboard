# Modernization Roi Calculator -- Workspace Configuration

## Overview
This workspace includes the **Modernization Roi Calculator** agent. Use when calculating ROI for cloud modernization including cost savings, agility gains, and risk reduction.

## Agent Invocation
- Use `@modernization-roi-calculator` to invoke the agent directly
- Use `/modernization-roi-calculator.prompt` for guided workflow prompts
- Use `/modernization-roi-calculator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODERNIZATIO_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `MODERNIZATIO_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `MODERNIZATIO_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `MODERNIZATIO_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `MODERNIZATIO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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