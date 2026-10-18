# Code Analysis Engine -- Workspace Configuration

## Overview
This workspace includes the **Code Analysis Engine** agent. Use when performing comprehensive codebase analysis including architecture mapping, security scanning (OWASP Top 10), dependency audits (SBOM/CVE), tech debt assessment, or generating repository health reports.

## Agent Invocation
- Use `@code-analysis-engine` to invoke the agent directly
- Use `/code-analysis-engine.prompt` for guided workflow prompts
- Use `/code-analysis-engine-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODE_ANALYSI_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `CODE_ANALYSI_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `CODE_ANALYSI_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `CODE_ANALYSI_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `CODE_ANALYSI_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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