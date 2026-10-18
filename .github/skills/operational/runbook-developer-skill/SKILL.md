---
description: "Runbook Developer skill -- Use when creating operational runbooks including incident response procedures, troubleshooting guides, and maintenance playbooks for new applications."
---

# Runbook Developer Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Runbook Developer operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When creating operational runbooks including incident response procedures, troubleshooting guides, and maintenance playbooks for new applications
- When business process knowledge and industry standards must be applied
- When compliance, governance, or regulatory requirements are involved
- When domain-specific risk assessment and mitigation planning are needed

## Capabilities

- Classify incidents by severity using impact, urgency, and blast radius assessment
- Execute structured triage with symptom analysis and correlation
- Perform root cause analysis through 5-Why, fishbone, and fault tree methods
- Execute containment and remediation actions with safety guardrails
- Manage escalation workflows with stakeholder notification
- Verify recovery through SLI restoration and user impact confirmation
- Conduct blameless post-incident reviews with action item tracking
- Generate incident reports with timeline, RCA, and preventive measures

## Procedure

1. Receive incident signal -- classify severity (P1-P4) based on impact, urgency, and blast radius
2. Gather incident context: alerts, logs, recent changes, affected services, and user reports
3. Perform initial triage -- identify symptoms, potential root causes, and affected scope
4. Execute containment actions to limit blast radius and prevent escalation
5. Investigate root cause through log analysis, metric correlation, and change timeline review
6. Apply remediation: execute runbook, deploy fix, or invoke automated recovery
7. Verify recovery: confirm service health, SLI restoration, and user impact resolution
8. Document findings: timeline, root cause, actions taken, and preventive recommendations
9. Generate incident report with RCA, impact summary, and follow-up action items

## Output Format

Return structured results:

- **Executive Summary**: key findings, risk level, and recommended actions
- **Findings**: finding ID, severity, category, description, evidence, remediation
- **Compliance Status**: framework, control ID, status (compliant/non-compliant/partial)
- **Action Items**: prioritized actions with ownership, timeline, and success criteria
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation plans

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **ITIL v4** | IT service management: incident, problem, change management |
| **SRE Principles (Google)** | SLO/SLI, error budgets, toil reduction, blameless postmortems |
| **ISO 20000** | IT service management system requirements |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER claim compliance without evidence from actual control evaluation
- ALWAYS verify regulatory applicability for the specific jurisdiction and context

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER override compliance requirements without documented exception approval
- ALWAYS maintain audit trail for all assessments and decisions
