---
description: "Portfolio Risk Analyzer skill -- Use when analyzing investment portfolio risk metrics including Value-at-Risk (VaR), Conditional VaR, Sharpe ratio, drawdown analysis, and stress testing across asset classes for high-net-worth and institutional portfolios."
---

# Portfolio Risk Analyzer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Portfolio Risk Analyzer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When calculating portfolio risk metrics: VaR, CVaR, Sharpe, Sortino, max drawdown
- When performing stress testing against historical and hypothetical scenarios
- When analyzing risk factor exposures: equity beta, duration, credit spread, FX
- When assessing portfolio diversification and concentration risk
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate parametric, historical, and Monte Carlo VaR at multiple confidence levels
- Compute Conditional VaR (Expected Shortfall) for tail risk assessment
- Perform factor-based risk decomposition: market, sector, style, currency
- Run historical stress tests: 2008 GFC, COVID-19, rate shock, credit crisis
- Calculate risk-adjusted return metrics: Sharpe, Sortino, Information Ratio
- Analyze maximum drawdown and recovery time across market cycles
- Assess concentration risk by issuer, sector, geography, and asset class
- Generate client-ready portfolio risk reports with visualizations

## Procedure

1. Extract portfolio holdings with market values, positions, and characteristics
2. Map securities to risk factors: equity beta, duration, spread, FX exposure
3. Calculate portfolio-level risk metrics using parametric and simulation methods
4. Perform historical stress test applying scenario shocks to risk factors
5. Decompose risk into systematic and idiosyncratic components
6. Identify concentration risks exceeding policy thresholds
7. Compare risk metrics against benchmark and peer portfolios
8. Generate comprehensive risk report with executive summary and detail sections
9. Present findings with recommended risk reduction or rebalancing actions

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
| **CFA Institute GIPS** | Global Investment Performance Standards for risk reporting |
| **Basel III Market Risk** | VaR and Expected Shortfall calculation methodologies |
| **UCITS (EU)** | Risk management and VaR limits for collective investment schemes |
| **SEC Rule 18f-4** | Derivatives risk management for registered investment companies |

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

- **Companion Agent**: `@portfolio-risk-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |