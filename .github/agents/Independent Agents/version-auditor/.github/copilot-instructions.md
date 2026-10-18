# Version Auditor -- Workspace Configuration

## Overview
This workspace includes the **Version Auditor** agent. Audit current versions of all dependencies, frameworks, and runtimes.

## Agent Invocation
- Use `@version-auditor` to invoke the agent directly
- Use `/version-auditor.prompt` for guided workflow prompts
- Use `/version-auditor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `VERSION_AUDI_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `VERSION_AUDI_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `VERSION_AUDI_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `VERSION_AUDI_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `VERSION_AUDI_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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