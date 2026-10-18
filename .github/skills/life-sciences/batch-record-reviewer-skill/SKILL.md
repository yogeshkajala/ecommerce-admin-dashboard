---
description: "Batch Record Reviewer skill -- Use when reviewing pharmaceutical manufacturing batch records including process parameter verification, in-process testing results, deviation documentation, and batch disposition decision support for GMP compliance."
---

# Batch Record Reviewer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Batch Record Reviewer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When reviewing batch records for GMP compliance before batch disposition
- When verifying process parameters against validated ranges and specifications
- When assessing in-process test results and out-of-specification investigations
- When evaluating deviation impact on batch quality and disposition decision
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Review batch record completeness and accuracy against master batch record
- Verify process parameters against validated ranges: temperature, pressure, time, pH, speed
- Validate in-process testing results against acceptance criteria
- Assess environmental monitoring data during manufacturing
- Evaluate deviations and their impact on product quality
- Check raw material traceability and release status
- Verify equipment cleaning and calibration records
- Generate batch record review report with disposition recommendation

## Procedure

1. Receive executed batch record with supporting documentation
2. Verify batch record identity: product, batch number, manufacturing date, equipment
3. Check all process parameters against validated ranges and specifications
4. Review in-process test results for each critical quality attribute
5. Evaluate any deviations: root cause, impact assessment, CAPA reference
6. Verify environmental monitoring results for manufacturing areas
7. Check component traceability: raw materials, intermediates, packaging
8. Validate all entries are complete, signed, and dated per GMP requirements
9. Generate review report with batch disposition recommendation: release, reject, or hold

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
| **21 CFR 211** | FDA cGMP requirements for batch record review and disposition |
| **EU GMP Annex 1** | Manufacture of sterile products batch record requirements |
| **ICH Q7** | GMP for active pharmaceutical ingredients batch documentation |
| **PIC/S PE 009** | PIC/S GMP Guide for batch record management |

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

- **Companion Agent**: `@batch-record-reviewer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |