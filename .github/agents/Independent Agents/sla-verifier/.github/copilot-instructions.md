# Sla Verifier -- Workspace Configuration

## Overview
This workspace includes the **Sla Verifier** agent. Use when verifying SLA compliance after upgrades -- availability, latency, and error rate targets.

## Agent Invocation
- Use `@sla-verifier` to invoke the agent directly
- Use `/sla-verifier.prompt` for guided workflow prompts
- Use `/sla-verifier-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SLA_VERIFIER_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SLA_VERIFIER_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SLA_VERIFIER_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SLA_VERIFIER_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SLA_VERIFIER_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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