# Policy Engine -- Workspace Configuration

## Overview
This workspace includes the **Policy Engine** agent. Use when enforcing governance policies as code, evaluating compliance, checking resources against policy rules, managing policy exceptions, or generating compliance reports.

## Agent Invocation
- Use `@policy-engine` to invoke the agent directly
- Use `/policy-engine.prompt` for guided workflow prompts
- Use `/policy-engine-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `POLICY_ENGIN_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `POLICY_ENGIN_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `POLICY_ENGIN_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `POLICY_ENGIN_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `POLICY_ENGIN_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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