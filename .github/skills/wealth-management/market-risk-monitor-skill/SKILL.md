---
description: "Market Risk Monitor skill -- Use when monitoring market risk exposures for wealth management portfolios including equity market sensitivity, interest rate risk, credit spread exposure, currency risk, and tail risk assessment."
---

# Market Risk Monitor Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Market Risk Monitor operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When monitoring portfolio sensitivity to equity market movements
- When assessing interest rate risk exposure across fixed income holdings
- When evaluating currency risk for international portfolio allocations
- When measuring tail risk and extreme loss potential for risk management
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate equity beta and sector factor exposures for portfolio risk assessment
- Measure interest rate sensitivity through DV01 and key rate duration analysis
- Assess credit spread risk using OAS-based spread duration
- Evaluate currency exposure from international holdings and hedging positions
- Calculate stress test P&L under historical and hypothetical scenarios
- Monitor VaR utilization against risk limits with breach alerting
- Assess tail risk through Expected Shortfall and extreme value theory
- Generate market risk dashboard with real-time and historical metrics

## Procedure

1. Extract portfolio positions with market data and risk characteristics
2. Calculate equity risk metrics: beta, tracking error, active share, sector tilts
3. Compute fixed income risk: duration, DV01, key rate duration, spread duration
4. Assess currency exposure by portfolio weight and hedging offset
5. Run stress test scenarios: rate shock, credit widening, equity selloff, FX move
6. Calculate portfolio VaR at 95% and 99% confidence levels
7. Identify risk concentrations exceeding policy or guideline thresholds
8. Generate market risk report with current exposures and stress test results
9. Recommend risk reduction or hedging actions for threshold breaches

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
| **CFA Risk Management** | Portfolio risk measurement and monitoring best practices |
| **Basel III Market Risk** | VaR and Expected Shortfall calculation methodologies |
| **GIPS Risk Measures** | Risk disclosure requirements for performance reporting |
| **SEC Rule 18f-4** | Derivatives risk management for registered funds |

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

- **Companion Agent**: `@market-risk-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |