# Security Validator -- Workspace Configuration

## Overview
This workspace includes the **Security Validator** agent. Use when validating application security including SAST, dependency scanning, secret detection, and OWASP Top 10 compliance.

## Agent Invocation
- Use `@security-validator` to invoke the agent directly
- Use `/security-validator.prompt` for guided workflow prompts
- Use `/security-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SECURITY_VAL_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SECURITY_VAL_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SECURITY_VAL_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SECURITY_VAL_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SECURITY_VAL_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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