# Cloud Native Validator -- Workspace Configuration

## Overview
This workspace includes the **Cloud Native Validator** agent. Use when verifying 12-Factor App compliance and cloud-native best practices for modernized applications.

## Agent Invocation
- Use `@cloud-native-validator` to invoke the agent directly
- Use `/cloud-native-validator.prompt` for guided workflow prompts
- Use `/cloud-native-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CLOUD_NATIVE_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `CLOUD_NATIVE_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `CLOUD_NATIVE_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `CLOUD_NATIVE_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `CLOUD_NATIVE_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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