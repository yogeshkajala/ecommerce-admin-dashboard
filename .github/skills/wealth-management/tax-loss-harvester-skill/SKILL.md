---
description: "Tax Loss Harvester skill -- Use when identifying and executing tax-loss harvesting opportunities across investment portfolios including loss identification, replacement security selection, wash sale avoidance, and year-end tax planning for taxable accounts."
---

# Tax Loss Harvester Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Tax Loss Harvester operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When scanning portfolios for unrealized losses available for harvesting
- When selecting replacement securities to maintain portfolio factor exposure
- When managing 30-day wash sale window across all household accounts
- When executing year-end tax planning with gain/loss offset optimization
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Scan portfolios for unrealized losses exceeding minimum threshold per lot
- Identify optimal lots for harvesting considering holding period and loss magnitude
- Select replacement securities maintaining similar factor exposure without wash sale
- Monitor 30-day wash sale lookback and forward windows across household accounts
- Calculate net tax savings considering federal, state, and NIIT rates
- Model gain/loss netting: short-term gains offset first for maximum benefit
- Track harvested losses and basis adjustments for long-term tax impact
- Generate tax-loss harvesting reports with realized savings documentation

## Procedure

1. Extract portfolio positions with tax lots, cost basis, and unrealized gain/loss
2. Identify positions with unrealized losses exceeding harvesting threshold
3. Rank harvesting opportunities by tax benefit: loss amount x tax rate
4. Select replacement securities with similar risk/return characteristics
5. Verify no wash sale conflict across all household accounts in 30-day window
6. Execute sell order for harvested lot and simultaneous buy for replacement
7. Confirm settlement and validate cost basis transfer records
8. Update wash sale monitoring database with new positions
9. Generate tax-loss harvesting report documenting actions and projected tax savings

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
| **IRC Section 1091** | Wash sale disallowance rules for substantially identical securities |
| **IRC Section 1001** | Capital gain/loss recognition and computation rules |
| **IRC Section 1(h)** | Capital gains tax rates: short-term, long-term, collectibles |
| **IRC Section 1411** | Net Investment Income Tax (NIIT) additional 3.8% assessment |

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

- **Companion Agent**: `@tax-loss-harvester` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |