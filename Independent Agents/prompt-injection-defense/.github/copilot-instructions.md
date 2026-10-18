# Prompt Injection Defense -- Workspace Configuration

## Overview
This workspace includes the **Prompt Injection Defense** agent. Use when defending against prompt injection attacks, sanitizing AI inputs, detecting adversarial prompts, isolating context boundaries, or responding to injection threats in agent workflows.

## Agent Invocation
- Use `@prompt-injection-defense` to invoke the agent directly
- Use `/prompt-injection-defense.prompt` for guided workflow prompts
- Use `/prompt-injection-defense-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PROMPT_INJEC_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `PROMPT_INJEC_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `PROMPT_INJEC_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `PROMPT_INJEC_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `PROMPT_INJEC_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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