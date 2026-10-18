---
description: "Equity Research Aggregator skill -- Use when aggregating and analyzing equity research from multiple sources including consensus estimates, target price analysis, recommendation trends, and earnings revision momentum for investment decision support."
---

# Equity Research Aggregator Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Equity Research Aggregator operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When aggregating sell-side research consensus estimates and recommendations
- When tracking earnings revision momentum and estimate dispersion
- When analyzing analyst target prices relative to current market prices
- When screening equities using fundamental and quantitative criteria
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Aggregate consensus estimates: EPS, revenue, EBITDA across time horizons
- Track earnings revision momentum: upgrades, downgrades, FY1/FY2 revisions
- Analyze sell-side recommendation distribution: buy, hold, sell trends
- Calculate consensus target price and implied upside/downside
- Screen equities using fundamental metrics: P/E, EV/EBITDA, PEG, FCF yield
- Monitor earnings surprise history and management guidance patterns
- Build custom screening models combining fundamental and technical factors
- Generate equity research summary reports for portfolio management team

## Procedure

1. Ingest sell-side research from data providers: FactSet, Bloomberg, Refinitiv
2. Normalize estimates to common fiscal period and currency
3. Calculate consensus metrics: mean, median, high, low, standard deviation
4. Track estimate revisions over 1-week, 1-month, and 3-month periods
5. Aggregate analyst recommendations with institutional weighting
6. Calculate consensus target price and implied return from current price
7. Apply custom screening criteria per investment strategy parameters
8. Generate research summary for each covered security
9. Distribute research aggregation reports to portfolio managers

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
| **CFA Institute Research Standards** | Equity research objectivity and diligence standards |
| **MiFID II Research Unbundling** | Research payment and inducement requirements |
| **FINRA Rule 2241** | Research analyst conflict of interest and disclosure rules |
| **Reg AC** | Analyst certification requirements for research reports |

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

- **Companion Agent**: `@equity-research-aggregator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |