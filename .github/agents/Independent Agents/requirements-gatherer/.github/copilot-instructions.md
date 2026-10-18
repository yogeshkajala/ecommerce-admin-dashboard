# Requirements Gatherer -- Workspace Configuration

## Overview
This workspace includes the **Requirements Gatherer** agent. Use when cataloging workloads, mapping dependencies, estimating costs, and checking compliance before cloud migration.

## Agent Invocation
- Use `@requirements-gatherer` to invoke the agent directly
- Use `/requirements-gatherer.prompt` for guided workflow prompts
- Use `/requirements-gatherer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REQUIREMENTS_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `REQUIREMENTS_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `REQUIREMENTS_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `REQUIREMENTS_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `REQUIREMENTS_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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