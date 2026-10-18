---
description: "Client Portfolio Rebalancer skill -- Use when rebalancing client investment portfolios including drift detection, tax-aware trading, wash sale avoidance, and multi-account household rebalancing across taxable and tax-advantaged accounts."
---

# Client Portfolio Rebalancer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Client Portfolio Rebalancer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When detecting portfolio drift beyond tolerance bands
- When executing tax-aware rebalancing minimizing capital gains realization
- When managing household-level rebalancing across multiple account types
- When implementing cash flow rebalancing for deposits and withdrawals
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Monitor portfolio drift against target allocation with configurable tolerance bands
- Generate tax-aware trade lists minimizing short-term capital gains
- Avoid wash sale violations across household accounts per IRC Section 1091
- Optimize asset location across taxable, IRA, and Roth account types
- Handle cash flow rebalancing directing new deposits to underweight asset classes
- Calculate rebalancing trade costs and tax impact before execution
- Manage model portfolio changes with mass rebalancing across client base
- Produce rebalancing transaction reports for client and compliance review

## Procedure

1. Calculate current allocation weights versus target allocation for each account
2. Identify positions drifting beyond tolerance bands requiring rebalancing
3. Determine optimal trade list to return to target with minimum transactions
4. Apply tax overlay: avoid short-term gains, harvest losses where beneficial
5. Check wash sale lookback for 30-day window across all household accounts
6. Optimize asset location: tax-inefficient assets in tax-advantaged accounts
7. Generate trade instructions for execution through order management system
8. Confirm execution and update portfolio records with new positions
9. Produce rebalancing summary report for client communication

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
| **IRC Section 1091** | Wash sale rules preventing loss recognition on repurchased securities |
| **Prudent Investor Rule** | Fiduciary obligation for periodic portfolio rebalancing |
| **GIPS** | Performance attribution after rebalancing transactions |
| **ERISA 404(a)** | Fiduciary duty for rebalancing retirement plan assets |

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

- **Companion Agent**: `@client-portfolio-rebalancer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |