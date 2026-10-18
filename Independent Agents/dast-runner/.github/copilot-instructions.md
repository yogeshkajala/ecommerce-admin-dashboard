# Dast Runner -- Workspace Configuration

## Overview
This workspace includes the **Dast Runner** agent. Use when running dynamic application security testing (DAST) against a live or staging application.

## Agent Invocation
- Use `@dast-runner` to invoke the agent directly
- Use `/dast-runner.prompt` for guided workflow prompts
- Use `/dast-runner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DAST_RUNNER_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `DAST_RUNNER_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `DAST_RUNNER_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `DAST_RUNNER_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `DAST_RUNNER_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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