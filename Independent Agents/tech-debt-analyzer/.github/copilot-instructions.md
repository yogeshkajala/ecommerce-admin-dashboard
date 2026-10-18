# Tech Debt Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Tech Debt Analyzer** agent. Evaluate technical debt, code quality, SBOM, vulnerability exposure, and remediation cost.

## Agent Invocation
- Use `@tech-debt-analyzer` to invoke the agent directly
- Use `/tech-debt-analyzer.prompt` for guided workflow prompts
- Use `/tech-debt-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TECH_DEBT_AN_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `TECH_DEBT_AN_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `TECH_DEBT_AN_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `TECH_DEBT_AN_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `TECH_DEBT_AN_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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