# Dependency Scanner -- Workspace Configuration

## Overview
This workspace includes the **Dependency Scanner** agent. Use when scanning dependencies for CVE vulnerabilities, outdated packages, license compliance issues, or generating SBOM (Software Bill of Materials).

## Agent Invocation
- Use `@dependency-scanner` to invoke the agent directly
- Use `/dependency-scanner.prompt` for guided workflow prompts
- Use `/dependency-scanner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_S_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `DEPENDENCY_S_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `DEPENDENCY_S_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `DEPENDENCY_S_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `DEPENDENCY_S_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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