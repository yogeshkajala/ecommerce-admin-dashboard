# Resource Rightsizer -- Workspace Configuration

## Overview
This workspace includes the **Resource Rightsizer** agent. Use when identifying over-provisioned or under-provisioned resources and recommending optimal sizing.

## Agent Invocation
- Use `@resource-rightsizer` to invoke the agent directly
- Use `/resource-rightsizer.prompt` for guided workflow prompts
- Use `/resource-rightsizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RESOURCE_RIG_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `RESOURCE_RIG_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `RESOURCE_RIG_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `RESOURCE_RIG_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `RESOURCE_RIG_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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