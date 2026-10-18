# Auto Scaling Configurer -- Workspace Configuration

## Overview
This workspace includes the **Auto Scaling Configurer** agent. Use when configuring auto-scaling policies for modernized cloud applications based on traffic patterns and SLA requirements.

## Agent Invocation
- Use `@auto-scaling-configurer` to invoke the agent directly
- Use `/auto-scaling-configurer.prompt` for guided workflow prompts
- Use `/auto-scaling-configurer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AUTO_SCALING_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `AUTO_SCALING_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `AUTO_SCALING_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `AUTO_SCALING_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `AUTO_SCALING_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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