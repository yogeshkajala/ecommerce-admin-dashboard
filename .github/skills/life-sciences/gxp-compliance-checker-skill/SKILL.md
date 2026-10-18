---
description: "GxP Compliance Checker skill -- Use when validating GxP compliance across pharmaceutical operations including GMP for manufacturing, GLP for laboratory studies, GCP for clinical trials, GDP for distribution, and GVP for pharmacovigilance."
---

# GxP Compliance Checker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GxP Compliance Checker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When assessing GMP compliance for pharmaceutical manufacturing operations
- When validating GLP compliance for nonclinical laboratory studies
- When checking GCP compliance for clinical trial conduct and documentation
- When evaluating GDP compliance for pharmaceutical distribution and logistics
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Assess GMP compliance against 21 CFR 210/211 and EU GMP Annex requirements
- Validate GLP study compliance per 21 CFR Part 58 and OECD GLP Principles
- Check GCP compliance against ICH E6(R2) for clinical trial documentation
- Evaluate GDP compliance for pharmaceutical storage and distribution
- Identify GxP gaps and classify by regulatory risk severity
- Map GxP requirements to Quality Management System processes
- Track GxP compliance trends across audits and inspections
- Generate GxP compliance assessment reports for quality management review

## Procedure

1. Determine applicable GxP regulations based on activity and jurisdiction
2. Map current processes and documentation to GxP requirements
3. Assess compliance for each requirement area: documentation, personnel, facilities, equipment
4. Identify gaps between current state and GxP requirements
5. Classify gaps by regulatory risk: critical, major, minor, observation
6. Evaluate CAPA effectiveness for previously identified GxP gaps
7. Generate compliance heatmap showing strength and weakness areas
8. Produce GxP compliance report with gap assessment and remediation plan
9. Track remediation implementation and verify effectiveness

## Output Format

Return structured results:

- **Executive Summary: key findings, compliance status, risk classification, recommended actions**
- **Detailed Analysis: line-by-line assessment with regulatory reference citations**
- **Regulatory Impact: applicable regulations, specific sections, compliance gap severity**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **21 CFR 210/211** | FDA cGMP requirements for pharmaceutical manufacturing |
| **21 CFR Part 58** | FDA GLP requirements for nonclinical laboratory studies |
| **ICH E6(R2)** | GCP requirements for clinical trial conduct |
| **EU GDP Guidelines** | Good Distribution Practice for pharmaceutical products |

## Anti-Hallucination Rules

- Do not fabricate clinical data or study results -- use actual protocol and study records
- Do not assume regulatory requirements without verifying current published guidance
- Do not generate synthetic patient data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published FDA/EMA guidance
- Cross-check GxP compliance assertions against specific regulation sections
- Validate all clinical data references against actual study database records
- Ensure all recommendations include regulatory risk impact assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@gxp-compliance-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |