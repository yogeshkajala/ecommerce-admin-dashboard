# Disaster Recovery Planner -- Workspace Configuration

## Overview
This workspace includes the **Disaster Recovery Planner** agent. Plan and validate disaster recovery procedures including failover, backup restoration, RTO/RPO targets, and DR testing.

## Agent Invocation
- Use `@disaster-recovery-planner` to invoke the agent directly
- Use `/disaster-recovery-planner.prompt` for guided workflow prompts
- Use `/disaster-recovery-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DISASTER_REC_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `DISASTER_REC_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `DISASTER_REC_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `DISASTER_REC_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `DISASTER_REC_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

## Key Conventions
- Critical findings block the pipeline by default
- All scans follow the configured compliance framework
- Secrets and credentials must never appear in outputs
- Transitive dependencies are included in scans
- Findings are deduplicated across scan runs

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations