# Code Quality Auditor -- Workspace Configuration

## Overview
This workspace includes the **Code Quality Auditor** agent. Use when auditing code quality including maintainability, complexity, duplication, test coverage, and coding standards compliance.

## Agent Invocation
- Use `@code-quality-auditor` to invoke the agent directly
- Use `/code-quality-auditor.prompt` for guided workflow prompts
- Use `/code-quality-auditor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_QUALITY_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `CODE_QUALITY_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `CODE_QUALITY_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `CODE_QUALITY_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `CODE_QUALITY_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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