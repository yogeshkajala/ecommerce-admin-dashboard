# Auto Fixer -- Workspace Configuration

## Overview
This workspace includes the **Auto Fixer** agent. Use when applying automated fixes for detected failure patterns, including service restarts, scaling, and configuration corrections.

## Agent Invocation
- Use `@auto-fixer` to invoke the agent directly
- Use `/auto-fixer.prompt` for guided workflow prompts
- Use `/auto-fixer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AUTO_FIXER_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `AUTO_FIXER_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `AUTO_FIXER_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `AUTO_FIXER_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `AUTO_FIXER_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

## Key Conventions
- Resources are validated against CIS benchmarks
- Rightsizing recommendations based on utilization threshold
- Cost alerts trigger at configured budget percentage
- Scaling strategy follows configured approach
- All provisioning changes are idempotent

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations