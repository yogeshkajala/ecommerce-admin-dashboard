# Security Scanner -- Workspace Configuration

## Overview
This workspace includes the **Security Scanner** agent. Use when scanning migrated cloud environments for security vulnerabilities and misconfigurations.

## Agent Invocation
- Use `@security-scanner` to invoke the agent directly
- Use `/security-scanner.prompt` for guided workflow prompts
- Use `/security-scanner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SECURITY_SCA_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SECURITY_SCA_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SECURITY_SCA_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SECURITY_SCA_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SECURITY_SCA_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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