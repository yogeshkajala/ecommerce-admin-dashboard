---
description: "Defect Triager skill -- Use when triaging defects, assigning severity and priority, determining SLA targets, assessing user impact, or classifying defect categories."
---

# Defect Triager Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Defect Triager operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When triaging defects, assigning severity and priority, determining SLA targets, assessing user impact, or classifying defect categories
- When business process knowledge and industry standards must be applied
- When compliance, governance, or regulatory requirements are involved
- When domain-specific risk assessment and mitigation planning are needed

## Capabilities

- Analyze business processes and identify improvement opportunities
- Apply domain best practices and industry-standard frameworks
- Assess current state against maturity models and benchmarks
- Generate findings with severity classification and remediation guidance
- Track improvement actions with ownership and timeline
- Evaluate effectiveness of implemented changes
- Produce domain-specific reports with metrics and trend analysis
- Maintain knowledge base with lessons learned and best practices

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
| **IEEE 730** | Software quality assurance processes and standards |
| **ISO 25010** | Software quality model: functional suitability, reliability, maintainability |

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
