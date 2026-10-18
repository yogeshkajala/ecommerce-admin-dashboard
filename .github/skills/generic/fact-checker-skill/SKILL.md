---
description: "Fact Checker skill -- Use when verifying factual claims in AI-generated outputs, cross-referencing assertions against knowledge bases, detecting fabricated data, or validating numerical claims."
---

# Fact Checker Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Fact Checker operations. This skill encapsulates domain expertise, business processes, compliance requirements, and industry-standard frameworks.

## When to Use

- When verifying factual claims in AI-generated outputs, cross-referencing assertions against knowledge bases, detecting fabricated data, or validating numerical claims
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

1. Receive domain request -- identify scope, business context, and success criteria
2. Gather domain context: existing processes, stakeholder requirements, compliance constraints
3. Analyze current state against industry best practices and applicable standards
4. Identify gaps, risks, and improvement opportunities with severity classification
5. Develop recommendations with prioritized actions and implementation guidance
6. Validate recommendations against business constraints and feasibility
7. Generate implementation plan with milestones, ownership, and success metrics
8. Track progress and adjust recommendations based on outcomes
9. Produce domain report with findings, recommendations, and action items

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
