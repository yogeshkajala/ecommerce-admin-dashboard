# Resource Planner -- Workspace Configuration

## Overview
This workspace includes the **Resource Planner** agent. Use when planning and managing project resources including team allocation, budget tracking, skill mapping, and vendor management.

## Agent Invocation
- Use `@resource-planner` to invoke the agent directly
- Use `/resource-planner.prompt` for guided workflow prompts
- Use `/resource-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RESOURCE_PLA_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `RESOURCE_PLA_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `RESOURCE_PLA_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `RESOURCE_PLA_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `RESOURCE_PLA_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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