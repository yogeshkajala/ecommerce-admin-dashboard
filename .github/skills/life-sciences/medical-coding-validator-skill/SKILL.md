---
description: "Medical Coding Validator skill -- Use when validating medical coding in clinical trials including MedDRA adverse event coding, WHO Drug Dictionary coding for medications, procedure coding, and coding consistency across multi-site clinical studies."
---

# Medical Coding Validator Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Medical Coding Validator operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When validating MedDRA coding accuracy for adverse events in clinical trials
- When coding concomitant medications using WHO Drug Dictionary
- When ensuring coding consistency across multiple clinical trial sites
- When updating coding dictionaries and managing version upgrades
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Validate MedDRA coding: verbatim to LLT/PT mapping accuracy
- Code concomitant medications to WHO Drug Dictionary: ATC, INN classification
- Ensure coding consistency across sites, studies, and therapeutic areas
- Manage dictionary version upgrades with impact assessment
- Perform auto-coding with medical review for ambiguous terms
- Track coding query resolution and turnaround times
- Generate coding quality metrics: auto-code rate, error rate, consistency
- Produce coding status reports for data management and medical review

## Procedure

1. Receive verbatim terms from EDC for medical coding
2. Apply auto-coding algorithms against current dictionary version
3. Route uncoded or ambiguous terms to medical coder for manual coding
4. Validate coding accuracy through medical review of coded terms
5. Check coding consistency against previously coded similar terms
6. Process dictionary version upgrade with impact analysis on existing codes
7. Resolve coding queries with site coordination when verbatim is unclear
8. Generate coding completion report with quality metrics
9. Validate coding completeness before database lock

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
| **MedDRA** | Medical Dictionary for Regulatory Activities for AE coding |
| **WHO Drug Dictionary** | WHO classification for medication coding in clinical trials |
| **CDISC CDASH** | Clinical Data Acquisition Standards Harmonization for coding fields |
| **ICH M1** | MedDRA maintenance and development organization |

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

- **Companion Agent**: `@medical-coding-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |