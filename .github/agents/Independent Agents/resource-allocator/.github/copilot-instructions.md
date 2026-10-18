# Resource Allocator -- Workspace Configuration

## Overview
This workspace includes the **Resource Allocator** agent. Allocate teams, tools, and cloud resources for each migration wave.

## Agent Invocation
- Use `@resource-allocator` to invoke the agent directly
- Use `/resource-allocator.prompt` for guided workflow prompts
- Use `/resource-allocator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RESOURCE_ALL_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `RESOURCE_ALL_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `RESOURCE_ALL_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `RESOURCE_ALL_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `RESOURCE_ALL_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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