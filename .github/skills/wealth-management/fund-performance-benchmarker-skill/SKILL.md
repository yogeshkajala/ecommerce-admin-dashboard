---
description: "Fund Performance Benchmarker skill -- Use when benchmarking investment fund performance including return attribution, peer comparison, risk-adjusted metrics, and GIPS-compliant performance reporting for managed portfolios and fund products."
---

# Fund Performance Benchmarker Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Fund Performance Benchmarker operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When calculating GIPS-compliant investment performance returns
- When performing return attribution analysis: allocation, selection, interaction effects
- When benchmarking fund performance against index and peer group universes
- When generating client-facing performance reports with regulatory disclosures
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate time-weighted and money-weighted returns per GIPS standards
- Perform Brinson-Fachler attribution: allocation, selection, interaction effects
- Benchmark against market indices with tracking error and information ratio analysis
- Compare performance against peer group universes with percentile ranking
- Calculate after-fee and after-tax returns for client-specific reporting
- Produce composite performance for GIPS firm-wide compliance
- Generate performance reports with required disclosures and disclaimers
- Detect performance anomalies and investigate calculation discrepancies

## Procedure

1. Extract portfolio return data with cash flows and benchmark index returns
2. Calculate time-weighted returns using modified Dietz or daily valuation method
3. Compute money-weighted returns (IRR) for client-specific performance measurement
4. Perform Brinson-Fachler attribution decomposing active return sources
5. Compare returns against relevant benchmark index over multiple time periods
6. Rank performance against peer universe with percentile and quartile classification
7. Calculate risk-adjusted metrics: Sharpe, Sortino, Information Ratio, Alpha
8. Generate GIPS-compliant performance report with required disclosures
9. Distribute performance reports through client reporting platform

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
| **CFA Institute GIPS** | Global Investment Performance Standards for return calculation and reporting |
| **SEC Marketing Rule (206(4)-1)** | Performance advertising requirements for investment advisors |
| **FINRA Rule 2210** | Communications with the public including performance presentation |
| **MiFID II PRIIPs** | Key information document performance presentation requirements |

## Anti-Hallucination Rules

- Do not fabricate portfolio performance data -- use actual client records only
- Do not assume market conditions without citing specific data sources
- Do not generate investment recommendations without proper suitability analysis
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent verification methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include client suitability considerations
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@fund-performance-benchmarker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |