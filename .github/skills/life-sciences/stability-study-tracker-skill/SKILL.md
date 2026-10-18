---
description: "Stability Study Tracker skill -- Use when managing pharmaceutical stability studies including ICH stability protocol design, storage condition monitoring, testing schedule management, shelf-life determination, and stability data trending for regulatory submission."
---

# Stability Study Tracker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Stability Study Tracker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When designing stability study protocols per ICH Q1A-Q1E guidelines
- When tracking stability testing schedules and sample pull dates
- When analyzing stability data trends for shelf-life determination
- When preparing stability sections for regulatory submission (CTD Module 3.2.P.8)
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Design stability protocols per ICH Q1A: conditions, time points, test parameters
- Track testing schedules with automated reminders for sample pull dates
- Monitor storage chamber conditions with excursion alerting
- Analyze stability data trends: physical, chemical, microbiological
- Determine shelf-life using ICH Q1E statistical analysis methods
- Manage photostability testing per ICH Q1B requirements
- Track stability commitments for post-approval regulatory obligations
- Generate stability data packages for CTD Module 3.2.P.8 regulatory submission

## Procedure

1. Design stability protocol: conditions, time points, testing parameters per ICH Q1A
2. Place stability samples in qualified storage chambers at required conditions
3. Monitor chamber conditions continuously with excursion alerting and investigation
4. Execute testing per schedule: appearance, assay, degradation products, dissolution, microbial
5. Enter results into stability database with data verification
6. Analyze trends using regression analysis per ICH Q1E methodology
7. Determine proposed shelf-life based on statistical analysis of trend data
8. Generate stability report for batch release and regulatory submission
9. Track post-approval stability commitments per regulatory conditions

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
| **ICH Q1A(R2)** | Stability testing of new drug substances and products |
| **ICH Q1B** | Photostability testing of new drug substances and products |
| **ICH Q1E** | Evaluation of stability data for shelf-life determination |
| **ICH Q5C** | Stability testing of biotechnological/biological products |

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

- **Companion Agent**: `@stability-study-tracker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |