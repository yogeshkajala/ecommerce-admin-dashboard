---
description: "Drug Labeling Reviewer skill -- Use when reviewing pharmaceutical product labeling including USPI (US Prescribing Information), SmPC (Summary of Product Characteristics), patient labeling, and promotional material review for regulatory compliance."
---

# Drug Labeling Reviewer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Drug Labeling Reviewer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When reviewing USPI structure and content compliance with FDA labeling regulations
- When evaluating SmPC compliance with EU labeling requirements
- When reviewing patient labeling: Medication Guide, patient package insert, PIL
- When assessing promotional material compliance with labeling claims
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Review USPI structure per PLR (Physician Labeling Rule) format requirements
- Validate labeling claims against clinical trial data and approved indications
- Assess SmPC compliance with EU QRD template and regulatory guidance
- Review Medication Guide and PPI for patient comprehension and accuracy
- Check promotional materials for consistency with approved labeling
- Evaluate labeling updates for safety information changes (boxed warnings, REMS)
- Track labeling negotiations with regulatory agencies
- Generate labeling review reports with compliance findings and recommendations

## Procedure

1. Receive labeling document for review: USPI, SmPC, PPI, or promotional material
2. Verify structural compliance with applicable format requirements (PLR, QRD)
3. Validate clinical claims against supporting data from clinical studies
4. Check safety information completeness: warnings, precautions, adverse reactions
5. Review dosage and administration for consistency with clinical data
6. Assess patient labeling for readability and comprehension level
7. Verify promotional claims are consistent with and supported by approved labeling
8. Generate labeling review report with findings and recommended changes
9. Track labeling revision through regulatory negotiation and approval

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
| **21 CFR 201** | FDA labeling requirements for human prescription drugs |
| **FDA PLR (Physician Labeling Rule)** | Format and content requirements for prescription drug labeling |
| **EU QRD Template** | EU quality review of documents template for SmPC and PIL |
| **FDCA Section 502** | Misbranding provisions for drug labeling and advertising |

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

- **Companion Agent**: `@drug-labeling-reviewer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |