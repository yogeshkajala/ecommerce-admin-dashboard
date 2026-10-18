# Capacity Scaler -- Workspace Configuration

## Overview
This workspace includes the **Capacity Scaler** agent. Make auto-scaling decisions and plan capacity based on demand patterns.

## Agent Invocation
- Use `@capacity-scaler` to invoke the agent directly
- Use `/capacity-scaler.prompt` for guided workflow prompts
- Use `/capacity-scaler-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CAPACITY_SCA_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `CAPACITY_SCA_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `CAPACITY_SCA_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `CAPACITY_SCA_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `CAPACITY_SCA_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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