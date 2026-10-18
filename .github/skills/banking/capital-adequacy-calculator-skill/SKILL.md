---
description: "Capital Adequacy Calculator skill -- Use when calculating regulatory capital adequacy ratios, risk-weighted assets, capital buffers, and G-SIB surcharges for compliance with Basel III/IV and US capital framework requirements."
---

# Capital Adequacy Calculator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Capital Adequacy Calculator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When calculating CET1, Tier 1, and Total Capital ratios
- When computing risk-weighted assets across credit, market, and operational risk
- When determining capital conservation buffer and countercyclical buffer requirements
- When assessing G-SIB surcharge using Method 1 and Method 2 calculations
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Calculate CET1 capital with all regulatory adjustments (goodwill, DTA, MSR)
- Compute credit risk RWA under Standardized and Advanced approaches
- Calculate market risk capital using FRTB standardized or internal models
- Determine operational risk capital under Standardized Measurement Approach
- Apply capital conservation buffer (2.5%) and institution-specific buffers
- Calculate G-SIB surcharge using BIS Method 1 (indicator-based) and Method 2 (substitution)
- Model capital impact of strategic transactions (M&A, divestitures, securitization)
- Generate regulatory capital reports for Federal Reserve, OCC, and FDIC

## Procedure

1. Extract balance sheet, off-balance-sheet, and P&L data from source systems
2. Classify capital instruments into CET1, AT1, and Tier 2 per eligibility criteria
3. Apply regulatory deductions and adjustments to each capital tier
4. Calculate credit risk RWA by exposure class with applicable risk weights
5. Compute market risk capital for trading book positions
6. Determine operational risk capital charge
7. Calculate CET1, Tier 1, Total Capital, and Leverage ratios
8. Apply buffers: capital conservation, countercyclical, G-SIB surcharge
9. Generate capital adequacy report with ratio trends and buffer analysis

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
| **Basel III/IV** | International capital adequacy framework and output floor |
| **Federal Reserve Reg Q** | US implementation of Basel III capital requirements |
| **FDIC Part 324** | FDIC capital adequacy regulations for insured institutions |
| **BIS BCBS Method 1/2** | G-SIB identification and surcharge calculation methodology |

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

- **Companion Agent**: `@capital-adequacy-calculator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |