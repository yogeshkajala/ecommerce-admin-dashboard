---
description: "Asset Allocation Optimizer skill -- Use when optimizing strategic and tactical asset allocation across portfolios using mean-variance optimization, Black-Litterman, risk parity, and factor-based approaches for wealth management clients."
---

# Asset Allocation Optimizer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Asset Allocation Optimizer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When designing strategic asset allocation for new client portfolios
- When rebalancing tactical allocation based on market outlook changes
- When implementing risk parity or factor-based allocation strategies
- When evaluating asset class return and correlation assumptions
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Run mean-variance optimization with constraints: min/max weights, turnover limits
- Implement Black-Litterman model incorporating advisor market views
- Design risk parity allocations equalizing risk contribution across asset classes
- Perform factor-based allocation targeting: growth, value, momentum, quality, low-vol
- Conduct asset-liability matching for goals-based wealth planning
- Generate efficient frontier with risk-return tradeoff visualization
- Back-test allocation strategies against historical market data
- Produce asset allocation recommendation reports for client review

## Procedure

1. Define investment universe: asset classes, sub-classes, and eligible vehicles
2. Establish capital market assumptions: expected returns, volatilities, correlations
3. Specify portfolio constraints: risk tolerance, liquidity, tax, regulatory
4. Run optimization model: MVO, Black-Litterman, or risk parity
5. Apply practical constraints: minimum position size, rebalancing frequency
6. Evaluate optimized allocation against current portfolio for transition cost
7. Generate tax-aware transition plan minimizing realized gains
8. Produce asset allocation report with rationale and expected outcomes
9. Schedule periodic review to reassess assumptions and rebalance

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
| **CFA Institute Asset Allocation** | Best practices for investment policy and asset allocation |
| **GIPS** | Performance reporting standards for allocation strategies |
| **Prudent Investor Rule** | Fiduciary standard for portfolio construction and diversification |
| **ERISA (if applicable)** | Fiduciary investment management for retirement accounts |

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

- **Companion Agent**: `@asset-allocation-optimizer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |