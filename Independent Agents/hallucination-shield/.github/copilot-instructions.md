# Hallucination Shield -- Workspace Configuration

## Overview
This workspace includes the **Hallucination Shield** agent. Use when verifying AI-generated outputs for hallucinations, grounding claims in evidence, calibrating confidence scores, or validating structured output schemas.

## Agent Invocation
- Use `@hallucination-shield` to invoke the agent directly
- Use `/hallucination-shield.prompt` for guided workflow prompts
- Use `/hallucination-shield-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `HALLUCINATIO_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `HALLUCINATIO_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `HALLUCINATIO_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `HALLUCINATIO_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `HALLUCINATIO_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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