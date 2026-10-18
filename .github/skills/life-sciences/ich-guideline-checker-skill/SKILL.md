---
description: "ICH Guideline Checker skill -- Use when checking pharmaceutical development and manufacturing compliance against ICH guidelines including Q1-Q14 quality guidelines, E-series efficacy guidelines, S-series safety guidelines, and M-series multidisciplinary guidelines."
---

# ICH Guideline Checker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for ICH Guideline Checker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When verifying compliance with ICH Q series quality guidelines for pharmaceutical manufacturing
- When checking clinical trial design against ICH E series efficacy guidelines
- When validating nonclinical study compliance with ICH S series safety guidelines
- When assessing regulatory submission format against ICH M series multidisciplinary guidelines
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Map pharmaceutical processes to applicable ICH quality guidelines (Q1-Q14)
- Verify clinical development compliance with ICH E series guidelines
- Validate nonclinical study adequacy against ICH S series guidelines
- Check submission format against ICH M series (CTD, eCTD, MedDRA)
- Identify gaps between current practices and ICH guideline requirements
- Track ICH guideline updates and assess impact on ongoing activities
- Generate ICH compliance assessment reports by guideline category
- Produce regulatory strategy recommendations based on ICH requirements

## Procedure

1. Identify applicable ICH guidelines based on product type and development phase
2. Map current processes and documentation to ICH guideline requirements
3. Assess compliance for each applicable guideline section
4. Identify gaps requiring remediation or process improvement
5. Evaluate impact of recent ICH guideline revisions on current activities
6. Recommend actions to achieve or maintain ICH compliance
7. Generate compliance matrix showing status by guideline and requirement
8. Produce summary report for regulatory strategy and quality management review
9. Track remediation progress and verify implementation effectiveness

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
| **ICH Q1-Q14** | Quality guidelines for stability, validation, impurities, specifications, QRM, QMS |
| **ICH E1-E19** | Efficacy guidelines for clinical trial design, safety, biostatistics |
| **ICH S1-S11** | Safety guidelines for carcinogenicity, genotoxicity, reproductive toxicity |
| **ICH M1-M12** | Multidisciplinary guidelines for CTD, MedDRA, drug interactions |

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

- **Companion Agent**: `@ich-guideline-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |