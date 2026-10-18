# Security Auditor -- Workspace Configuration

## Overview
This workspace includes the **Security Auditor** agent. Audit cloud security: IAM, encryption, network policies, compliance.

## Agent Invocation
- Use `@security-auditor` to invoke the agent directly
- Use `/security-auditor.prompt` for guided workflow prompts
- Use `/security-auditor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SECURITY_AUD_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SECURITY_AUD_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SECURITY_AUD_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SECURITY_AUD_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SECURITY_AUD_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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