# Policy Parser -- Workspace Configuration

## Overview
This workspace includes the **Policy Parser** agent. Use when parsing policy definitions from OPA/Rego, JSON Schema, or YAML rule files, validating policy syntax, resolving policy dependencies, or compiling policies for evaluation.

## Agent Invocation
- Use `@policy-parser` to invoke the agent directly
- Use `/policy-parser.prompt` for guided workflow prompts
- Use `/policy-parser-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `POLICY_PARSE_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `POLICY_PARSE_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `POLICY_PARSE_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `POLICY_PARSE_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `POLICY_PARSE_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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