---
description: "Safety Database Reconciler skill -- Use when reconciling safety databases including ICSR reconciliation between sponsors and partners, global safety database integrity validation, duplicate case detection, and regulatory compliance for pharmacovigilance data management."
---

# Safety Database Reconciler Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Safety Database Reconciler operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When reconciling ICSRs between sponsor safety database and partner/CRO databases
- When detecting and merging duplicate safety cases within global safety database
- When validating safety database data integrity and completeness
- When preparing safety database for regulatory inspection or audit
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Reconcile ICSRs between safety databases: sponsor, partner, CRO, regulatory
- Detect duplicate cases using patient, event, and reporter matching algorithms
- Validate data integrity: mandatory fields, coding accuracy, causality consistency
- Track reconciliation status with exception management and resolution
- Verify regulatory submission status: filed, pending, overdue by case and authority
- Validate data migration accuracy during safety database system changes
- Generate reconciliation reports with metrics and exception summaries
- Produce data quality dashboards for pharmacovigilance operations management

## Procedure

1. Extract ICSR data from sponsor safety database and partner/CRO databases
2. Apply matching criteria: patient initials, event dates, reporter, product
3. Identify matched cases and verify data consistency across databases
4. Detect potential duplicate cases within each database
5. Investigate unmatched cases to determine if expected or missing
6. Resolve data discrepancies through coordination between database owners
7. Track duplicate case merging through completion
8. Generate reconciliation report with matched, unmatched, and duplicate metrics
9. Certify reconciliation completion for audit and regulatory inspection

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
| **ICH E2B(R3)** | ICSR data elements for reconciliation and data exchange |
| **EU GVP Module VI** | Collection, management, and submission of ICSR reports |
| **FDA Safety Reporting** | Post-marketing safety reporting and database requirements |
| **ICH E2D** | Post-approval safety data management and reconciliation |

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

- **Companion Agent**: `@safety-database-reconciler` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |