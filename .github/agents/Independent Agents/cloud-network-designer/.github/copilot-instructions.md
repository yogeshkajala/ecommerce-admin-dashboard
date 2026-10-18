# Cloud Network Designer -- Workspace Configuration

## Overview
This workspace includes the **Cloud Network Designer** agent. Use when designing cloud networking including VPC, subnets, security groups, ingress controllers, and service mesh.

## Agent Invocation
- Use `@cloud-network-designer` to invoke the agent directly
- Use `/cloud-network-designer.prompt` for guided workflow prompts
- Use `/cloud-network-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CLOUD_NETWOR_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `CLOUD_NETWOR_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `CLOUD_NETWOR_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `CLOUD_NETWOR_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `CLOUD_NETWOR_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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