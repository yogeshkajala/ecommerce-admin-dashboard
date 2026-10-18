---
description: "Suspicious Activity Reporter skill -- Use when generating Suspicious Activity Reports (SARs) for FinCEN, managing SAR filing workflows, ensuring narrative quality and completeness, and tracking SAR filing deadlines and continuing activity reports."
---

# Suspicious Activity Reporter Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Suspicious Activity Reporter operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When drafting SAR narratives with required five W elements
- When managing SAR filing deadlines (30-day initial, 60-day with subject)
- When filing continuing activity SARs for ongoing suspicious patterns
- When reviewing SAR quality for completeness before BSA Officer approval
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Draft SAR narratives incorporating who, what, when, where, why elements
- Validate SAR form fields for completeness and internal consistency
- Track filing deadlines: 30 days from detection, 60 days if subject identified
- Manage continuing activity SAR filings for 90-day review cycles
- Cross-reference related SARs for subject and transaction linkage
- Generate SAR supporting documentation package with transaction evidence
- Validate e-filing format for FinCEN BSA E-Filing System submission
- Produce SAR filing metrics and trend analysis for BSA Officer reporting

## Procedure

1. Receive alert escalation or referral with supporting transaction data
2. Compile chronological transaction timeline with amounts, parties, and patterns
3. Draft SAR narrative addressing the five W elements with factual specificity
4. Complete SAR form fields: filing institution, subject, suspicious activity type
5. Validate narrative against form fields for consistency and completeness
6. Submit to BSA Officer for review and approval
7. File SAR electronically via FinCEN BSA E-Filing System
8. Set calendar reminder for 90-day continuing activity review
9. Archive SAR filing with all supporting documentation per 5-year retention

## Output Format

Return structured results:

- **Executive Summary: key findings, risk level, compliance status, recommended actions**
- **Detailed Analysis: line-by-line assessment results with evidence references**
- **Regulatory Mapping: applicable regulations, specific sections, compliance status**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **BSA/AML** | SAR filing requirements under Bank Secrecy Act |
| **FinCEN SAR Guidance** | SAR form instructions and narrative writing guidance |
| **Federal Reserve SR 01-18** | BSA/AML examination procedures for SAR compliance |
| **31 CFR 1020.320** | Regulatory SAR filing requirements for banks |

## Anti-Hallucination Rules

- Do not fabricate regulatory citations -- verify all statute and regulation references
- Do not assume institution-specific policies without explicit documentation
- Do not generate synthetic financial data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include implementation feasibility assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@suspicious-activity-reporter` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |