# Access Reviewer -- Workspace Configuration

## Overview
This workspace includes the **Access Reviewer** agent. Use when reviewing IAM policies, auditing service account permissions, checking least privilege compliance, or detecting stale access.

## Agent Invocation
- Use `@access-reviewer` to invoke the agent directly
- Use `/access-reviewer.prompt` for guided workflow prompts
- Use `/access-reviewer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ACCESS_REVIE_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `ACCESS_REVIE_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `ACCESS_REVIE_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `ACCESS_REVIE_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `ACCESS_REVIE_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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