---
description: "Derivatives Valuation skill -- Use when valuing derivative instruments in wealth management portfolios including options, structured notes, interest rate swaps, and currency forwards for performance reporting and risk management."
---

# Derivatives Valuation Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Derivatives Valuation operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When valuing options positions using Black-Scholes and binomial models
- When pricing structured notes with embedded options and exotic payoffs
- When marking interest rate swaps and currency forwards to market
- When assessing Greeks (delta, gamma, vega, theta) for options risk management
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Price European and American options using Black-Scholes and binomial tree models
- Value structured notes decomposing into bond + embedded option components
- Calculate interest rate swap fair values using yield curve bootstrapping
- Mark currency forwards and options using covered interest rate parity
- Compute option Greeks for risk management: delta, gamma, vega, theta, rho
- Validate counterparty valuations for OTC derivative collateral management
- Generate derivative position reports with P&L attribution
- Produce derivative risk reports for portfolio and compliance monitoring

## Procedure

1. Identify derivative positions and instrument characteristics
2. Source market data: spot prices, volatilities, yield curves, correlations
3. Select appropriate valuation model for each instrument type
4. Calculate fair values using market-standard pricing methodologies
5. Compute Greeks for options positions for risk management
6. Compare valuations against counterparty marks for OTC derivatives
7. Generate daily derivative P&L with attribution to risk factors
8. Produce derivative position and exposure reports
9. Validate all valuations against independent pricing sources

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
| **ASC 815** | Derivative accounting and hedge accounting requirements |
| **ISDA Definitions** | Standard definitions for OTC derivative valuation |
| **Black-Scholes-Merton** | Standard option pricing model for European options |
| **ASC 820** | Fair value measurement for derivative instruments |

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

- **Companion Agent**: `@derivatives-valuation` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |