# Feature Code Reviewer -- Workspace Configuration

## Overview
This workspace includes the **Feature Code Reviewer** agent. Use when reviewing feature code for correctness, backward compatibility, security (OWASP Top 10), and adherence to existing patterns.

## Agent Invocation
- Use `@feature-code-reviewer` to invoke the agent directly
- Use `/feature-code-reviewer.prompt` for guided workflow prompts
- Use `/feature-code-reviewer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_CODE_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `FEATURE_CODE_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `FEATURE_CODE_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `FEATURE_CODE_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `FEATURE_CODE_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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