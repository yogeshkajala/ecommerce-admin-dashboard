# Compliance Validator -- Workspace Configuration

## Overview
This workspace includes the **Compliance Validator** agent. Use when verifying migrated workloads meet regulatory and compliance requirements including data residency, audit logging, and retention policies.

## Agent Invocation
- Use `@compliance-validator` to invoke the agent directly
- Use `/compliance-validator.prompt` for guided workflow prompts
- Use `/compliance-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPLIANCE_V_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `COMPLIANCE_V_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `COMPLIANCE_V_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `COMPLIANCE_V_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `COMPLIANCE_V_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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