# Compliance Checker -- Workspace Configuration

## Overview
This workspace includes the **Compliance Checker** agent. Use when assessing regulatory and compliance requirements for workloads before cloud migration.

## Agent Invocation
- Use `@compliance-checker` to invoke the agent directly
- Use `/compliance-checker.prompt` for guided workflow prompts
- Use `/compliance-checker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPLIANCE_C_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `COMPLIANCE_C_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `COMPLIANCE_C_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `COMPLIANCE_C_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `COMPLIANCE_C_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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