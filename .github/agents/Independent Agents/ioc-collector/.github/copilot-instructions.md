# Ioc Collector -- Workspace Configuration

## Overview
This workspace includes the **Ioc Collector** agent. Collect and correlate Indicators of Compromise (IOCs) from logs, threat feeds, and infrastructure telemetry for threat detection.

## Agent Invocation
- Use `@ioc-collector` to invoke the agent directly
- Use `/ioc-collector.prompt` for guided workflow prompts
- Use `/ioc-collector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `IOC_COLLECTO_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `IOC_COLLECTO_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `IOC_COLLECTO_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `IOC_COLLECTO_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `IOC_COLLECTO_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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