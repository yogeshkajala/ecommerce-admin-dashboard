# Roi Reporter -- Workspace Configuration

## Overview
This workspace includes the **Roi Reporter** agent. Use when generating ROI reports, executive business case documents, investment comparison tables, or one-page investment summaries.

## Agent Invocation
- Use `@roi-reporter` to invoke the agent directly
- Use `/roi-reporter.prompt` for guided workflow prompts
- Use `/roi-reporter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROI_REPORTER_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `ROI_REPORTER_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `ROI_REPORTER_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `ROI_REPORTER_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `ROI_REPORTER_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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