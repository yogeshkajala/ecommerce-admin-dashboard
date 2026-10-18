# Cost Projector -- Workspace Configuration

## Overview
This workspace includes the **Cost Projector** agent. Project cloud costs using TCO model: compute, storage, network, licensing.

## Agent Invocation
- Use `@cost-projector` to invoke the agent directly
- Use `/cost-projector.prompt` for guided workflow prompts
- Use `/cost-projector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COST_PROJECT_BUDGET_ALERT` | `80` | Budget utilization alert threshold (%) |
| `COST_PROJECT_ANALYSIS_WINDOW` | `30d` | Cost analysis lookback window |
| `COST_PROJECT_SAVINGS_MIN` | `10` | Minimum savings percentage to recommend (%) |
| `COST_PROJECT_INCLUDE_RESERVED` | `true` | Include reserved instance analysis |
| `COST_PROJECT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, csv |

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