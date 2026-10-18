# Target Arch Designer -- Workspace Configuration

## Overview
This workspace includes the **Target Arch Designer** agent. Use when designing target cloud compute architecture, service selection, and infrastructure blueprints.

## Agent Invocation
- Use `@target-arch-designer` to invoke the agent directly
- Use `/target-arch-designer.prompt` for guided workflow prompts
- Use `/target-arch-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TARGET_ARCH__PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `TARGET_ARCH__RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `TARGET_ARCH__SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `TARGET_ARCH__COST_ALERTS` | `true` | Enable cost threshold alerts |
| `TARGET_ARCH__COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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