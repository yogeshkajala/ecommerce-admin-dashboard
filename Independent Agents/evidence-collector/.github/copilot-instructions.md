# Evidence Collector -- Workspace Configuration

## Overview
This workspace includes the **Evidence Collector** agent. Collect, organize, and validate compliance evidence artifacts for audit preparation and continuous compliance monitoring.

## Agent Invocation
- Use `@evidence-collector` to invoke the agent directly
- Use `/evidence-collector.prompt` for guided workflow prompts
- Use `/evidence-collector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `EVIDENCE_COL_FRAMEWORK` | `soc2` | Compliance framework: soc2, iso27001, pci-dss, hipaa |
| `EVIDENCE_COL_SEVERITY_THRESHOLD` | `medium` | Minimum violation severity to report |
| `EVIDENCE_COL_AUTO_REMEDIATE` | `false` | Auto-remediate low-risk violations |
| `EVIDENCE_COL_EVIDENCE_COLLECTION` | `true` | Auto-collect compliance evidence |
| `EVIDENCE_COL_AUDIT_LOG` | `true` | Enable audit trail logging |

## Key Conventions
- Compliance checks follow configured framework
- Evidence collection is automatic for audit readiness
- Violations above severity threshold are reported
- Audit trail logging is enabled by default
- Auto-remediation is opt-in for low-risk violations

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations