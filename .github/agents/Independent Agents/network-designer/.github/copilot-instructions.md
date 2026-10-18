# Network Designer -- Workspace Configuration

## Overview
This workspace includes the **Network Designer** agent. Design cloud networking: VPCs, subnets, load balancers, DNS, CDN configuration.

## Agent Invocation
- Use `@network-designer` to invoke the agent directly
- Use `/network-designer.prompt` for guided workflow prompts
- Use `/network-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `NETWORK_DESI_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `NETWORK_DESI_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `NETWORK_DESI_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `NETWORK_DESI_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `NETWORK_DESI_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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