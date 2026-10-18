# Quality Validator -- Workspace Configuration

## Overview
This workspace includes the **Quality Validator** agent. Use when validating quality across all dimensions including code quality, security, performance, and accessibility for new development.

## Agent Invocation
- Use `@quality-validator` to invoke the agent directly
- Use `/quality-validator.prompt` for guided workflow prompts
- Use `/quality-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `QUALITY_VALI_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `QUALITY_VALI_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `QUALITY_VALI_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `QUALITY_VALI_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `QUALITY_VALI_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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