# Infra Writer -- Workspace Configuration

## Overview
This workspace includes the **Infra Writer** agent. Use when generating infrastructure-as-code: Terraform modules, Dockerfiles, Helm charts, CI/CD pipelines, and cloud resource templates.

## Agent Invocation
- Use `@infra-writer` to invoke the agent directly
- Use `/infra-writer.prompt` for guided workflow prompts
- Use `/infra-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INFRA_WRITER_PROVIDER` | `auto` | Cloud provider: aws, azure, gcp, auto-detect |
| `INFRA_WRITER_RIGHTSIZING_THRESHOLD` | `40` | CPU utilization threshold for rightsizing (%) |
| `INFRA_WRITER_SCALING_STRATEGY` | `target-tracking` | Scaling strategy: target-tracking, step, scheduled |
| `INFRA_WRITER_COST_ALERTS` | `true` | Enable cost threshold alerts |
| `INFRA_WRITER_COMPLIANCE_CHECK` | `true` | Validate against CIS benchmarks |

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