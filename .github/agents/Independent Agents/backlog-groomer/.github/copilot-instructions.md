# Backlog Groomer -- Workspace Configuration

## Overview
This workspace includes the **Backlog Groomer** agent. Use when grooming backlogs: breaking epics into stories, estimating, and ensuring INVEST compliance.

## Agent Invocation
- Use `@backlog-groomer` to invoke the agent directly
- Use `/backlog-groomer.prompt` for guided workflow prompts
- Use `/backlog-groomer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `BACKLOG_GROO_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `BACKLOG_GROO_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `BACKLOG_GROO_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `BACKLOG_GROO_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `BACKLOG_GROO_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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