# Iac Developer -- Workspace Configuration

## Overview
This workspace includes the **Iac Developer** agent. Use when developing infrastructure as code templates including cloud resources, networking, security groups, and managed services.

## Agent Invocation
- Use `@iac-developer` to invoke the agent directly
- Use `/iac-developer.prompt` for guided workflow prompts
- Use `/iac-developer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `IAC_DEVELOPE_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `IAC_DEVELOPE_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `IAC_DEVELOPE_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `IAC_DEVELOPE_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `IAC_DEVELOPE_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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