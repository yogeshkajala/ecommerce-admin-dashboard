# Threat Detector -- Workspace Configuration

## Overview
This workspace includes the **Threat Detector** agent. Use when detecting security threats, analyzing SIEM alerts, mapping kill chains, or investigating indicators of compromise.

## Agent Invocation
- Use `@threat-detector` to invoke the agent directly
- Use `/threat-detector.prompt` for guided workflow prompts
- Use `/threat-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `THREAT_DETEC_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `THREAT_DETEC_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `THREAT_DETEC_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `THREAT_DETEC_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `THREAT_DETEC_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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