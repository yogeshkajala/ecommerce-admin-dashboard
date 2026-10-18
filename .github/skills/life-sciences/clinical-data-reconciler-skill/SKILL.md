---
description: "Clinical Data Reconciler skill -- Use when reconciling clinical trial data across source documents, EDC systems, laboratory databases, and safety databases ensuring data integrity, audit trail compliance, and ALCOA+ principles for GCP data management."
---

# Clinical Data Reconciler Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Clinical Data Reconciler operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When reconciling EDC data against source documents and medical records
- When validating safety data consistency between EDC, safety database, and ICSRs
- When reconciling laboratory data between central and local lab databases
- When verifying data integrity compliance with ALCOA+ principles
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Reconcile CRF/EDC data against source documents for accuracy verification
- Cross-reference safety data between EDC adverse event forms and safety database
- Validate laboratory data consistency between central lab, local lab, and EDC entries
- Check ALCOA+ compliance: Attributable, Legible, Contemporaneous, Original, Accurate
- Track and resolve data discrepancies through query management workflow
- Validate audit trail integrity for electronic source data
- Monitor data reconciliation progress against study milestones
- Generate data reconciliation reports with discrepancy metrics and trending

## Procedure

1. Extract clinical data from EDC, safety database, central lab, and local systems
2. Perform automated cross-system matching on key fields: subject, visit, date, event
3. Identify discrepancies: missing, mismatched, inconsistent, or duplicate records
4. Classify discrepancies by type and severity per data management plan
5. Generate data queries for site resolution of identified discrepancies
6. Track query response and resolution through to closure
7. Validate corrected data and verify audit trail documentation
8. Generate data reconciliation status report with metrics and trends
9. Confirm reconciliation completion before database lock

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
| **ICH E6(R2)** | GCP data management and quality requirements for clinical trials |
| **ALCOA+ Principles** | Data integrity framework for pharmaceutical data management |
| **21 CFR Part 11** | Electronic records and electronic signatures compliance |
| **FDA Data Integrity Guidance** | Data reliability and integrity expectations for clinical data |

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

- **Companion Agent**: `@clinical-data-reconciler` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |