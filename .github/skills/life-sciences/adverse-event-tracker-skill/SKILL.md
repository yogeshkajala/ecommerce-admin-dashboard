---
description: "Adverse Event Tracker skill -- Use when tracking adverse events throughout clinical trial conduct including AE/SAE collection, causality assessment, MedDRA coding, expedited reporting compliance, and safety data trending for clinical operations."
---

# Adverse Event Tracker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Adverse Event Tracker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When tracking adverse events and serious adverse events across clinical trial sites
- When assessing causality for adverse events per investigator and sponsor assessment
- When coding adverse events using MedDRA terminology with quality review
- When monitoring expedited reporting timelines for regulatory compliance
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Track AE/SAE collection across all trial sites with completeness monitoring
- Manage causality assessment workflow: investigator assessment and sponsor override
- Code adverse events using MedDRA: LLT, PT, HLT, HLGT, SOC hierarchy
- Monitor expedited reporting deadlines: 15-day fatal/life-threatening, 15-day unexpected
- Calculate AE rates: incidence, prevalence, exposure-adjusted by treatment arm
- Identify safety trends through cumulative AE analysis and comparisons
- Generate safety data listings and tables for DSMB and regulatory review
- Produce AE tracking dashboards with compliance metrics and safety signals

## Procedure

1. Receive adverse event data from clinical trial sites via EDC or paper CRF
2. Validate AE data completeness: verbatim term, dates, severity, outcome, causality
3. Code verbatim terms to MedDRA preferred terms and SOC with medical review
4. Assess seriousness criteria: death, life-threatening, hospitalization, disability
5. Evaluate expectedness against Reference Safety Information (IB or label)
6. Determine expedited reporting requirement based on seriousness and expectedness
7. Process expedited reports within regulatory timelines (IND safety report, SUSAR)
8. Update cumulative safety tables and monitor for emerging safety trends
9. Generate safety data review package for DSMB and safety review committee

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
| **ICH E2A** | Clinical safety data management definitions and standards for expedited reporting |
| **ICH E2B(R3)** | Individual case safety report electronic transmission requirements |
| **MedDRA** | Medical Dictionary for Regulatory Activities coding terminology |
| **21 CFR 312.32** | FDA IND safety reporting requirements and timelines |

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

- **Companion Agent**: `@adverse-event-tracker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |