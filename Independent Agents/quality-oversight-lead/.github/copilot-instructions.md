# Quality Oversight Lead -- Workspace Configuration

## Overview
This workspace includes the **Quality Oversight Lead** agent. Use when overseeing project quality including review gates, metric tracking, process compliance, and audit readiness.

## Agent Invocation
- Use `@quality-oversight-lead` to invoke the agent directly
- Use `/quality-oversight-lead.prompt` for guided workflow prompts
- Use `/quality-oversight-lead-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `QUALITY_OVER_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `QUALITY_OVER_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `QUALITY_OVER_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `QUALITY_OVER_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `QUALITY_OVER_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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