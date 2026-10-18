# Containerizer -- Workspace Configuration

## Overview
This workspace includes the **Containerizer** agent. Use when containerizing applications with optimized Dockerfiles, multi-stage builds, and security hardening.

## Agent Invocation
- Use `@containerizer` to invoke the agent directly
- Use `/containerizer.prompt` for guided workflow prompts
- Use `/containerizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTAINERIZE_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `CONTAINERIZE_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `CONTAINERIZE_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `CONTAINERIZE_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `CONTAINERIZE_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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