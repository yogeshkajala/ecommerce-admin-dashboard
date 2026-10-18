---
description: "Best Execution Analyzer skill -- Use when analyzing trade execution quality for best execution compliance including venue analysis, execution benchmark comparison, transaction cost analysis, and best execution policy monitoring for wealth management trading desks."
---

# Best Execution Analyzer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Best Execution Analyzer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When analyzing trade execution quality against best execution benchmarks
- When performing transaction cost analysis: explicit costs, implicit costs, opportunity costs
- When monitoring execution venue selection and routing decisions
- When generating best execution reports for regulatory compliance
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Compare execution prices against benchmarks: VWAP, arrival price, closing price
- Calculate implementation shortfall decomposition: timing, market impact, opportunity
- Analyze execution venue quality: fill rates, price improvement, execution speed
- Monitor broker performance across execution quality dimensions
- Assess dark pool and ATS utilization versus lit venue execution quality
- Evaluate algorithmic trading strategy effectiveness and parameter tuning
- Generate RTS 28 best execution reports for MiFID II compliance
- Produce transaction cost analysis dashboard for investment committee

## Procedure

1. Extract trade execution data from OMS and execution venues
2. Match executions against relevant benchmarks: VWAP, arrival, close
3. Calculate explicit costs: commissions, exchange fees, clearing costs
4. Estimate implicit costs: market impact, spread cost, timing cost
5. Compute implementation shortfall for each trade and aggregate by strategy
6. Analyze venue selection decisions against execution quality metrics
7. Evaluate broker comparative performance over rolling time periods
8. Generate quarterly best execution report per regulatory requirements
9. Present findings to best execution committee with recommendations

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
| **SEC Rule 606** | Order routing disclosure requirements for broker-dealers |
| **MiFID II RTS 28** | Annual best execution venue reporting requirements |
| **FINRA Rule 5310** | Best execution and interpositioning requirements |
| **CFA Transaction Cost Analysis** | TCA best practices for implementation shortfall analysis |

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

- **Companion Agent**: `@best-execution-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |