# Control Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Control Evaluator** agent. Evaluate compliance controls against regulatory frameworks (SOC2, ISO 27001, HIPAA, GDPR, PCI-DSS) and report control effectiveness.

## Agent Invocation
- Use `@control-evaluator` to invoke the agent directly
- Use `/control-evaluator.prompt` for guided workflow prompts
- Use `/control-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTROL_EVAL_FRAMEWORK` | `soc2` | Compliance framework: soc2, iso27001, pci-dss, hipaa |
| `CONTROL_EVAL_SEVERITY_THRESHOLD` | `medium` | Minimum violation severity to report |
| `CONTROL_EVAL_AUTO_REMEDIATE` | `false` | Auto-remediate low-risk violations |
| `CONTROL_EVAL_EVIDENCE_COLLECTION` | `true` | Auto-collect compliance evidence |
| `CONTROL_EVAL_AUDIT_LOG` | `true` | Enable audit trail logging |

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