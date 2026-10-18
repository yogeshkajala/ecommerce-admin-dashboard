---
description: "Labeling Compliance Checker skill -- Use when checking pharmaceutical labeling compliance including container labeling, carton labeling, serialization marking, country-specific labeling requirements, and artwork management for global pharmaceutical distribution."
---

# Labeling Compliance Checker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Labeling Compliance Checker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When verifying container and carton labeling against regulatory requirements
- When checking serialization data carrier quality and readability
- When validating country-specific labeling requirements for global distribution
- When managing artwork approval workflows for labeling changes
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Verify label content against approved regulatory labeling text
- Check serialization data carriers: 2D barcodes, human-readable text quality
- Validate country-specific requirements: language, symbols, controlled substance markings
- Manage artwork lifecycle: creation, proofing, approval, printing, archival
- Verify Braille compliance for EU packaging requirements
- Check label dimensions and placement against packaging specifications
- Validate batch-specific variable data: lot number, expiry date, NDC/GTIN
- Generate labeling compliance reports for quality release and regulatory audit

## Procedure

1. Receive packaging artwork or label specimen for compliance review
2. Compare label content against approved regulatory text (USPI, SmPC, PIL)
3. Verify required elements: product name, strength, dosage form, route, storage conditions
4. Check serialization data carrier: GS1 DataMatrix, readability, data accuracy
5. Validate country-specific requirements: language, symbols, scheduling markings
6. Verify Braille where required (EU member states)
7. Check variable data fields: format, position, readability specifications
8. Generate compliance checklist with pass/fail for each requirement
9. Issue labeling compliance certificate or deficiency notice

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
| **21 CFR 201** | FDA drug labeling requirements for container and carton labels |
| **EU FMD** | EU Falsified Medicines Directive serialization and tamper evidence |
| **GS1 General Specifications** | Barcode and data carrier specifications for pharmaceutical labeling |
| **EU Directive 2001/83/EC** | EU labeling requirements for medicinal products |

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

- **Companion Agent**: `@labeling-compliance-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |