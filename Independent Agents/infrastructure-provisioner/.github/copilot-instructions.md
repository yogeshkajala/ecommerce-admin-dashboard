# Infrastructure Provisioner -- Workspace Configuration

## Overview
This workspace includes the **Infrastructure Provisioner** agent. Use when provisioning cloud infrastructure for modernized applications using Infrastructure-as-Code.

## Agent Invocation
- Use `@infrastructure-provisioner` to invoke the agent directly
- Use `/infrastructure-provisioner.prompt` for guided workflow prompts
- Use `/infrastructure-provisioner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INFRASTRUCTU_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `INFRASTRUCTU_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `INFRASTRUCTU_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `INFRASTRUCTU_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `INFRASTRUCTU_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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