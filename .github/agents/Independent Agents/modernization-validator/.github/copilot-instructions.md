# Modernization Validator -- Workspace Configuration

## Overview
This workspace includes the **Modernization Validator** agent. Use when validating modernized applications for cloud-native compliance, scalability, resilience, and cost efficiency.

## Agent Invocation
- Use `@modernization-validator` to invoke the agent directly
- Use `/modernization-validator.prompt` for guided workflow prompts
- Use `/modernization-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODERNIZATIO_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `MODERNIZATIO_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `MODERNIZATIO_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `MODERNIZATIO_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `MODERNIZATIO_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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