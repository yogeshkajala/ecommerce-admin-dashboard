# Policy Enforcer -- Workspace Configuration

## Overview
This workspace includes the **Policy Enforcer** agent. Enforce governance policies across infrastructure, code, and processes. Detect violations and recommend or apply remediation.

## Agent Invocation
- Use `@policy-enforcer` to invoke the agent directly
- Use `/policy-enforcer.prompt` for guided workflow prompts
- Use `/policy-enforcer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `POLICY_ENFOR_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `POLICY_ENFOR_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `POLICY_ENFOR_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `POLICY_ENFOR_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `POLICY_ENFOR_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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