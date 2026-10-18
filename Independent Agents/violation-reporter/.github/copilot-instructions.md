# Violation Reporter -- Workspace Configuration

## Overview
This workspace includes the **Violation Reporter** agent. Use when generating compliance reports, summarizing policy violations, providing remediation guidance, or creating audit-ready compliance documentation.

## Agent Invocation
- Use `@violation-reporter` to invoke the agent directly
- Use `/violation-reporter.prompt` for guided workflow prompts
- Use `/violation-reporter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `VIOLATION_RE_FRAMEWORK` | `soc2` | Compliance framework: soc2, iso27001, pci-dss, hipaa |
| `VIOLATION_RE_SEVERITY_THRESHOLD` | `medium` | Minimum violation severity to report |
| `VIOLATION_RE_AUTO_REMEDIATE` | `false` | Auto-remediate low-risk violations |
| `VIOLATION_RE_EVIDENCE_COLLECTION` | `true` | Auto-collect compliance evidence |
| `VIOLATION_RE_AUDIT_LOG` | `true` | Enable audit trail logging |

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