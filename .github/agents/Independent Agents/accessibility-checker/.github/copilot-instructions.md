# Accessibility Checker -- Workspace Configuration

## Overview
This workspace includes the **Accessibility Checker** agent. Use when validating accessibility compliance including WCAG 2.1 conformance, screen reader compatibility, keyboard navigation, and color contrast.

## Agent Invocation
- Use `@accessibility-checker` to invoke the agent directly
- Use `/accessibility-checker.prompt` for guided workflow prompts
- Use `/accessibility-checker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ACCESSIBILIT_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `ACCESSIBILIT_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `ACCESSIBILIT_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `ACCESSIBILIT_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `ACCESSIBILIT_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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