---
description: "Retirement Planning Modeler skill -- Use when modeling retirement income strategies including withdrawal rate analysis, Social Security optimization, RMD planning, Roth conversion laddering, and longevity risk assessment for wealth management clients."
---

# Retirement Planning Modeler Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Retirement Planning Modeler operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When modeling retirement income sustainability using Monte Carlo simulation
- When optimizing Social Security claiming strategies for couples
- When planning Required Minimum Distribution strategies across IRA types
- When analyzing Roth conversion laddering for long-term tax optimization
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Run Monte Carlo retirement income simulations with 1000+ scenario iterations
- Model Social Security claiming strategies optimizing lifetime benefit
- Calculate Required Minimum Distributions across traditional IRA and 401(k) accounts
- Analyze Roth conversion ladder strategies with tax bracket optimization
- Assess longevity risk with mortality table analysis and insurance solutions
- Model income layering: Social Security, pensions, annuities, portfolio withdrawals
- Project tax liability through retirement incorporating all income sources
- Generate retirement planning reports with probability of success metrics

## Procedure

1. Gather client retirement data: assets, income sources, expenses, goals, health status
2. Define retirement income needs adjusted for inflation and lifestyle changes
3. Model Social Security claiming scenarios: early, FRA, delayed, spousal strategies
4. Calculate RMD schedules from age 73 (SECURE Act 2.0) across all retirement accounts
5. Analyze Roth conversion opportunities within current marginal tax bracket
6. Run Monte Carlo simulation with current asset allocation and withdrawal strategy
7. Assess probability of portfolio sustainability through age 95 or beyond
8. Identify gaps and recommend adjustments: savings rate, allocation, retirement age
9. Generate comprehensive retirement plan report with action items

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
| **SECURE Act 2.0** | RMD age changes and retirement plan contribution updates |
| **IRC Section 408A** | Roth IRA conversion rules and ordering provisions |
| **Social Security Administration** | Benefit calculation, claiming rules, and spousal strategies |
| **IRS Life Expectancy Tables** | Uniform Lifetime and Joint Life tables for RMD calculation |

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

- **Companion Agent**: `@retirement-planning-modeler` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |