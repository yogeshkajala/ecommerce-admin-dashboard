# Waste Detector -- Workspace Configuration

## Overview
This workspace includes the **Waste Detector** agent. Use when identifying unused resources, orphaned storage, idle compute, or other cloud waste.

## Agent Invocation
- Use `@waste-detector` to invoke the agent directly
- Use `/waste-detector.prompt` for guided workflow prompts
- Use `/waste-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `WASTE_DETECT_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `WASTE_DETECT_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `WASTE_DETECT_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `WASTE_DETECT_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `WASTE_DETECT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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