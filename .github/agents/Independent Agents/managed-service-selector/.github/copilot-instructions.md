# Managed Service Selector -- Workspace Configuration

## Overview
This workspace includes the **Managed Service Selector** agent. Use when selecting cloud managed services to replace self-managed infrastructure components.

## Agent Invocation
- Use `@managed-service-selector` to invoke the agent directly
- Use `/managed-service-selector.prompt` for guided workflow prompts
- Use `/managed-service-selector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MANAGED_SERV_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `MANAGED_SERV_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `MANAGED_SERV_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `MANAGED_SERV_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `MANAGED_SERV_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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