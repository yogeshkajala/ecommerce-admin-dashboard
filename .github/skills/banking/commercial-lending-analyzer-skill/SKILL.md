---
description: "Commercial Lending Analyzer skill -- Use when analyzing commercial lending portfolios including credit analysis, financial spreading, covenant monitoring, risk rating assignment, and concentration risk management for C&I and CRE exposures."
---

# Commercial Lending Analyzer Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Commercial Lending Analyzer operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When performing financial statement spreading and trend analysis for commercial borrowers
- When monitoring loan covenant compliance and early warning indicators
- When assigning and validating commercial credit risk ratings
- When analyzing portfolio concentration risk by industry, geography, and collateral type
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Spread financial statements: income statement, balance sheet, cash flow
- Calculate key financial ratios: leverage, coverage, liquidity, profitability
- Monitor covenant compliance with automated threshold checking and alerts
- Assign risk ratings using dual rating system (borrower and facility)
- Analyze portfolio concentrations against policy limits and regulatory guidance
- Assess CRE exposure by property type, geography, and LTV bands
- Track classified and criticized asset migration and remediation
- Generate commercial lending portfolio reports for credit committee

## Procedure

1. Extract borrower financial statements and loan portfolio data
2. Spread financial statements into standardized format for analysis
3. Calculate financial ratios and compare to industry benchmarks and trends
4. Check covenant compliance against all financial and non-financial covenants
5. Validate risk ratings using quantitative scorecard and qualitative assessment
6. Analyze portfolio concentration against approved limits by all dimensions
7. Identify early warning indicators: rating migration, watch list, past due
8. Generate credit review report with risk assessment and recommendations
9. Produce portfolio management report for credit committee review

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
| **OCC Comptroller Handbook - CRE** | Commercial real estate lending concentration guidance |
| **Interagency CRE Guidance (2006)** | Concentration risk management for CRE lending |
| **Basel III** | Credit risk capital calculation for commercial exposures |
| **FASB ASC 310** | Receivables accounting and loan impairment assessment |

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

- **Companion Agent**: `@commercial-lending-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |