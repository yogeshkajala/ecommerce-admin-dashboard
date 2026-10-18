---
description: "Loan Origination Analyzer skill -- Use when analyzing loan origination workflows for efficiency, compliance with TRID (TILA-RESPA Integrated Disclosure), HMDA reporting accuracy, and end-to-end cycle time optimization from application through funding."
---

# Loan Origination Analyzer Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Loan Origination Analyzer operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When optimizing loan origination cycle time from application to closing
- When validating TRID disclosure timing and content compliance
- When analyzing HMDA data quality for regulatory submission
- When assessing loan origination system integration and data flow
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Map end-to-end loan origination workflow identifying bottlenecks and rework loops
- Validate Loan Estimate and Closing Disclosure compliance with TRID timing rules
- Analyze HMDA LAR data for completeness, accuracy, and geocoding correctness
- Calculate tolerance cure amounts for changed circumstances
- Identify origination fee and APR calculation errors before closing
- Track pipeline velocity metrics by product, channel, and loan officer
- Generate TRID compliance exception reports with remediation guidance
- Produce HMDA submission-ready LAR files with validation edits cleared

## Procedure

1. Map current origination workflow from application intake through post-closing
2. Identify cycle time by stage: application, processing, underwriting, closing, funding
3. Validate TRID Loan Estimate delivery within 3 business days of application
4. Check Closing Disclosure delivery at least 3 business days before consummation
5. Verify fee tolerance calculations and changed circumstance documentation
6. Analyze HMDA data fields for accuracy against source documents
7. Generate compliance scorecard with pass/fail by regulatory requirement
8. Recommend workflow optimizations with projected cycle time improvements
9. Produce audit-ready documentation package for regulatory examination

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
| **TRID (TILA-RESPA)** | Integrated mortgage disclosure timing and content requirements |
| **HMDA (Reg C)** | Home Mortgage Disclosure Act data collection and reporting |
| **ECOA (Reg B)** | Fair lending in mortgage origination and adverse action |
| **RESPA (Reg X)** | Real Estate Settlement Procedures Act servicing rules |

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

- **Companion Agent**: `@loan-origination-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |