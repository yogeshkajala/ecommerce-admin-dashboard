# Policy Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Policy Evaluator** agent. Use when evaluating resources, configurations, or actions against parsed policy rules, checking compliance status, or performing batch policy evaluation.

## Agent Invocation
- Use `@policy-evaluator` to invoke the agent directly
- Use `/policy-evaluator.prompt` for guided workflow prompts
- Use `/policy-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `POLICY_EVALU_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `POLICY_EVALU_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `POLICY_EVALU_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `POLICY_EVALU_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `POLICY_EVALU_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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