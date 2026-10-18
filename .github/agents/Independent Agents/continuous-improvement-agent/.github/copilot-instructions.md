# Continuous Improvement Agent -- Workspace Configuration

## Overview
This workspace includes the **Continuous Improvement Agent** agent. Use when driving continuous improvement from quality findings, retrospectives, and audit results.

## Agent Invocation
- Use `@continuous-improvement-agent` to invoke the agent directly
- Use `/continuous-improvement-agent.prompt` for guided workflow prompts
- Use `/continuous-improvement-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTINUOUS_I_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `CONTINUOUS_I_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `CONTINUOUS_I_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `CONTINUOUS_I_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `CONTINUOUS_I_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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