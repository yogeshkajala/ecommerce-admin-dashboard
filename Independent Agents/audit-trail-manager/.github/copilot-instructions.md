# Audit Trail Manager -- Workspace Configuration

## Overview
This workspace includes the **Audit Trail Manager** agent. Manage and query audit trails for compliance investigations, change tracking, and regulatory reporting requirements.

## Agent Invocation
- Use `@audit-trail-manager` to invoke the agent directly
- Use `/audit-trail-manager.prompt` for guided workflow prompts
- Use `/audit-trail-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AUDIT_TRAIL__SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `AUDIT_TRAIL__SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `AUDIT_TRAIL__BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `AUDIT_TRAIL__INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `AUDIT_TRAIL__COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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