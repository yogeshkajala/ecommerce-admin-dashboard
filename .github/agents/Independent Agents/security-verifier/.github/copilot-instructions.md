# Security Verifier -- Workspace Configuration

## Overview
This workspace includes the **Security Verifier** agent. Verify no new vulnerabilities introduced by the upgrade.

## Agent Invocation
- Use `@security-verifier` to invoke the agent directly
- Use `/security-verifier.prompt` for guided workflow prompts
- Use `/security-verifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SECURITY_VER_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SECURITY_VER_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SECURITY_VER_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SECURITY_VER_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SECURITY_VER_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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