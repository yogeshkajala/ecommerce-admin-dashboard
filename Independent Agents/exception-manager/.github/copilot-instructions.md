# Exception Manager -- Workspace Configuration

## Overview
This workspace includes the **Exception Manager** agent. Use when managing policy exceptions, granting temporary waivers, tracking exception lifecycle, revoking expired exceptions, or auditing exception usage.

## Agent Invocation
- Use `@exception-manager` to invoke the agent directly
- Use `/exception-manager.prompt` for guided workflow prompts
- Use `/exception-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EXCEPTION_MA_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `EXCEPTION_MA_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `EXCEPTION_MA_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `EXCEPTION_MA_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `EXCEPTION_MA_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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