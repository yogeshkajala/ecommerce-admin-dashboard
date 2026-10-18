# Security Planner -- Workspace Configuration

## Overview
This workspace includes the **Security Planner** agent. Plan migration security: IAM migration, network security, data protection, and compliance mapping.

## Agent Invocation
- Use `@security-planner` to invoke the agent directly
- Use `/security-planner.prompt` for guided workflow prompts
- Use `/security-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SECURITY_PLA_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SECURITY_PLA_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SECURITY_PLA_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SECURITY_PLA_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SECURITY_PLA_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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