---
description: "Dependency Audit skill -- Use when auditing dependency health including CVEs, outdated packages, license compliance, and transitive dependency risks."
---

# Dependency Audit Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Dependency Audit operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When auditing dependency health including CVEs, outdated packages, license compliance, and transitive dependency risks
- When business process knowledge and industry standards must be applied
- When compliance, governance, or regulatory requirements are involved
- When domain-specific risk assessment and mitigation planning are needed

## Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance
- Track remediation progress and verify corrective action implementation
- Maintain compliance evidence repositories with attestation documentation
- Conduct risk assessments with likelihood and impact scoring
- Produce compliance reports with control mapping and attestation evidence

## Procedure

1. Receive security/compliance request -- identify scope, applicable frameworks, and evidence requirements
2. Gather current posture: existing controls, policies, recent assessments, known gaps
3. Evaluate controls against applicable framework requirements (SOC2, ISO 27001, PCI-DSS, GDPR)
4. Identify findings: control gaps, policy violations, configuration weaknesses
5. Classify findings by severity and compliance impact -- map to specific control requirements
6. Collect evidence: screenshots, configurations, audit logs, attestation documents
7. Generate remediation plan with prioritized actions, ownership, and timelines
8. Validate remediation effectiveness through re-assessment and evidence review
9. Produce compliance report with control status, evidence references, and attestation summary

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
| **SOC 2 Type II** | Trust service criteria: security, availability, processing integrity |
| **ISO 27001** | Information security management system (ISMS) controls |
| **GDPR/CCPA** | Data privacy and protection regulatory requirements |

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
