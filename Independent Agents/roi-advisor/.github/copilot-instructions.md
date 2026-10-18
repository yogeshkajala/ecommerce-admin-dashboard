# Roi Advisor -- Workspace Configuration

## Overview
This workspace includes the **Roi Advisor** agent. Use when evaluating ROI for technology investments, building executive business cases, analyzing cost-benefit, projecting savings (NPV/IRR/payback), or comparing investment alternatives.

## Agent Invocation
- Use `@roi-advisor` to invoke the agent directly
- Use `/roi-advisor.prompt` for guided workflow prompts
- Use `/roi-advisor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROI_ADVISOR_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `ROI_ADVISOR_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `ROI_ADVISOR_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `ROI_ADVISOR_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `ROI_ADVISOR_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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