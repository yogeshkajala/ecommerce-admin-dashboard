---
description: "Regulatory Reporting Generator skill -- Use when generating regulatory reports for banking supervisors including Call Reports (FFIEC 031/041), FR Y-9C, CCAR/DFAST stress test submissions, and other prudential reporting requirements."
---

# Regulatory Reporting Generator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Regulatory Reporting Generator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When preparing quarterly Call Reports for FDIC/OCC submission
- When generating FR Y-9C consolidated financial statements for Federal Reserve
- When producing CCAR and DFAST stress testing submissions
- When validating regulatory report data quality and reconciliation
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Generate FFIEC 031/041 Call Report schedules from general ledger data
- Produce FR Y-9C consolidated financial statements with inter-company eliminations
- Calculate stress test scenarios for CCAR/DFAST with macroeconomic variable projections
- Validate data lineage from source systems through transformation to report output
- Reconcile regulatory report totals to audited financial statements
- Identify and remediate data quality issues before submission deadlines
- Generate submission-ready XBRL filings for electronic regulatory submission
- Produce variance analysis comparing current period to prior quarters

## Procedure

1. Extract general ledger and sub-ledger data as of reporting date
2. Apply regulatory mapping rules to classify accounts per report taxonomy
3. Execute inter-company elimination entries for consolidated reporting
4. Calculate regulatory capital ratios (CET1, Tier 1, Total Capital)
5. Validate report totals against audited financial statements and prior submissions
6. Run regulatory edit checks matching FFIEC validation criteria
7. Generate variance analysis with explanations for material changes
8. Produce XBRL-tagged submission files for electronic filing
9. Archive complete data lineage documentation for examiner review

## Output Format

Return structured results:

- **Executive Summary: key findings, risk level, compliance status, recommended actions**
- **Detailed Analysis: line-by-line assessment results with evidence references**
- **Regulatory Mapping: applicable regulations, specific sections, compliance status**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **FFIEC 031/041** | Call Report instructions for domestic and foreign office banks |
| **FR Y-9C** | Federal Reserve consolidated financial statements for BHCs |
| **Basel III** | Capital adequacy calculation methodology and ratios |
| **CCAR/DFAST** | Comprehensive Capital Analysis and Review stress testing framework |

## Anti-Hallucination Rules

- Do not fabricate regulatory citations -- verify all statute and regulation references
- Do not assume institution-specific policies without explicit documentation
- Do not generate synthetic financial data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include implementation feasibility assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@regulatory-reporting-generator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |