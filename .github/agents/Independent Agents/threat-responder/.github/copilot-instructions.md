# Threat Responder -- Workspace Configuration

## Overview
This workspace includes the **Threat Responder** agent. Use when responding to detected prompt injection threats, blocking malicious inputs, quarantining suspicious content, escalating to human review, or logging injection attempts for forensics.

## Agent Invocation
- Use `@threat-responder` to invoke the agent directly
- Use `/threat-responder.prompt` for guided workflow prompts
- Use `/threat-responder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `THREAT_RESPO_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `THREAT_RESPO_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `THREAT_RESPO_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `THREAT_RESPO_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `THREAT_RESPO_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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