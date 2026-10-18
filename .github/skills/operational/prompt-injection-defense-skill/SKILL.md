---
description: "Prompt Injection Defense skill -- Use when defending against prompt injection attacks, sanitizing AI inputs, detecting adversarial prompts, isolating context boundaries, or responding to injection threats in agent workflows."
---

# Prompt Injection Defense Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Prompt Injection Defense operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When defending against prompt injection attacks, sanitizing AI inputs, detecting adversarial prompts, isolating context boundaries, or responding to injection threats in agent workflows
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
