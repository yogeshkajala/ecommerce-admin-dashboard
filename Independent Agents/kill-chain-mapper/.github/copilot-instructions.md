# Kill Chain Mapper -- Workspace Configuration

## Overview
This workspace includes the **Kill Chain Mapper** agent. Map observed attack patterns and techniques to MITRE ATT and CK kill chain phases for threat classification and response planning.

## Agent Invocation
- Use `@kill-chain-mapper` to invoke the agent directly
- Use `/kill-chain-mapper.prompt` for guided workflow prompts
- Use `/kill-chain-mapper-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `KILL_CHAIN_M_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `KILL_CHAIN_M_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `KILL_CHAIN_M_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `KILL_CHAIN_M_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `KILL_CHAIN_M_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

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