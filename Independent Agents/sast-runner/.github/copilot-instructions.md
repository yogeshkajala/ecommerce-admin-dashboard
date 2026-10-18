# Sast Runner -- Workspace Configuration

## Overview
This workspace includes the **Sast Runner** agent. Use when running static application security testing (SAST) to find vulnerabilities in source code.

## Agent Invocation
- Use `@sast-runner` to invoke the agent directly
- Use `/sast-runner.prompt` for guided workflow prompts
- Use `/sast-runner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SAST_RUNNER_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `SAST_RUNNER_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `SAST_RUNNER_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `SAST_RUNNER_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `SAST_RUNNER_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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