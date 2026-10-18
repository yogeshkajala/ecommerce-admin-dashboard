# Billing Anomaly Detector -- Workspace Configuration

## Overview
This workspace includes the **Billing Anomaly Detector** agent. Detect billing anomalies, unexpected cost spikes, budget threshold breaches, and misconfigured resources driving excess spending.

## Agent Invocation
- Use `@billing-anomaly-detector` to invoke the agent directly
- Use `/billing-anomaly-detector.prompt` for guided workflow prompts
- Use `/billing-anomaly-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BILLING_ANOM_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `BILLING_ANOM_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `BILLING_ANOM_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `BILLING_ANOM_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `BILLING_ANOM_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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