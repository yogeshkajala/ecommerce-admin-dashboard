---
description: "Fixed Income Analyzer skill -- Use when analyzing fixed income portfolios and securities including yield curve analysis, duration and convexity management, credit spread analysis, and fixed income attribution for wealth management portfolios."
---

# Fixed Income Analyzer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Fixed Income Analyzer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When analyzing bond portfolio duration, convexity, and yield characteristics
- When evaluating credit risk exposure across fixed income portfolio
- When performing yield curve scenario analysis for interest rate sensitivity
- When conducting fixed income performance attribution
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate duration metrics: effective, modified, Macaulay, key rate durations
- Analyze yield curve scenarios: parallel shift, steepening, flattening, twist
- Evaluate credit spread risk across rating categories and sectors
- Perform OAS analysis for mortgage-backed and callable securities
- Model bond cash flows for amortizing, callable, and putable structures
- Calculate portfolio yield metrics: current yield, YTM, YTW, YTC
- Conduct Campisi-style fixed income attribution: income, Treasury, spread, selection
- Generate fixed income portfolio analytics reports for client review

## Procedure

1. Extract fixed income portfolio holdings with security characteristics
2. Calculate security-level analytics: duration, convexity, OAS, yield metrics
3. Aggregate to portfolio level with market-value weighted calculations
4. Analyze duration positioning relative to benchmark and policy range
5. Evaluate credit quality distribution against benchmark and policy guidelines
6. Model interest rate scenarios and calculate portfolio price sensitivity
7. Perform cash flow analysis for income projection and reinvestment planning
8. Conduct performance attribution decomposing return sources
9. Generate fixed income portfolio report with analytics and recommendations

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
| **CFA Fixed Income Curriculum** | Duration, convexity, and yield analysis best practices |
| **GIPS** | Fixed income performance calculation and attribution standards |
| **SEC Rule 2a-7** | Money market fund valuation and risk management |
| **Basel III** | Credit risk assessment for fixed income securities |

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

- **Companion Agent**: `@fixed-income-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |