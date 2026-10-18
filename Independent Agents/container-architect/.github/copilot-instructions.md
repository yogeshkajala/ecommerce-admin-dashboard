# Container Architect -- Workspace Configuration

## Overview
This workspace includes the **Container Architect** agent. Use when designing containerization strategy including Dockerfiles, Kubernetes manifests, resource limits, and scaling policies.

## Agent Invocation
- Use `@container-architect` to invoke the agent directly
- Use `/container-architect.prompt` for guided workflow prompts
- Use `/container-architect-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTAINER_AR_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `CONTAINER_AR_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `CONTAINER_AR_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `CONTAINER_AR_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `CONTAINER_AR_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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