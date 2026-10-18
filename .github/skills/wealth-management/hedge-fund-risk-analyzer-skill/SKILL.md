---
description: "Hedge Fund Risk Analyzer skill -- Use when analyzing hedge fund risk characteristics including strategy-specific risk factors, leverage analysis, liquidity risk assessment, counterparty exposure, and operational risk evaluation for fund-of-fund or direct allocations."
---

# Hedge Fund Risk Analyzer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Hedge Fund Risk Analyzer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When analyzing hedge fund strategy risk factors and return drivers
- When assessing hedge fund leverage, liquidity terms, and redemption provisions
- When evaluating counterparty exposure and prime broker concentration
- When conducting operational risk assessment on hedge fund managers
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Decompose hedge fund returns into strategy-specific risk factors
- Analyze leverage: gross, net, and risk-adjusted leverage ratios
- Assess liquidity risk: redemption terms, gates, side pockets, lockups
- Evaluate counterparty concentration across prime brokers and OTC counterparties
- Calculate risk metrics: maximum drawdown, Calmar ratio, omega ratio
- Perform style analysis using rolling window return-based factor regression
- Assess operational risk: valuation practices, governance, compliance, technology
- Generate hedge fund risk assessment reports for investment committee

## Procedure

1. Collect hedge fund data: returns, AUM, strategy description, terms, and structure
2. Perform return-based style analysis using factor regression models
3. Calculate risk metrics: volatility, drawdown, Sharpe, Sortino, Calmar
4. Analyze leverage levels relative to strategy norms and fund guidelines
5. Assess liquidity profile: redemption frequency, notice period, gates, lockups
6. Evaluate counterparty exposure concentration across prime brokers
7. Conduct operational due diligence assessment scoring
8. Compare risk metrics against strategy peer group and benchmarks
9. Generate comprehensive risk assessment with recommendation

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
| **AIMA DDQ** | Alternative Investment Management Association Due Diligence Questionnaire |
| **CAIA Association Standards** | Alternative investment analysis and risk assessment framework |
| **SEC Form PF** | Systemic risk reporting for large hedge fund managers |
| **ISDA Master Agreement** | OTC derivative counterparty risk management framework |

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

- **Companion Agent**: `@hedge-fund-risk-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |