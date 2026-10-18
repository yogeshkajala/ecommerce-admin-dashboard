---
description: "Wealth Tax Optimizer skill -- Use when optimizing tax strategies for high-net-worth clients including tax-loss harvesting, asset location optimization, charitable giving strategies, Roth conversion analysis, and estate tax planning."
---

# Wealth Tax Optimizer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Wealth Tax Optimizer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When identifying and executing tax-loss harvesting opportunities across portfolios
- When optimizing asset location between taxable and tax-advantaged accounts
- When analyzing Roth conversion strategies and break-even time horizons
- When evaluating charitable giving strategies: DAF, CRT, qualified appreciated stock
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Scan portfolios for tax-loss harvesting opportunities with wash sale avoidance
- Optimize asset location placing tax-inefficient assets in deferred accounts
- Model Roth conversion scenarios with projected tax bracket and RMD analysis
- Evaluate charitable strategies: donor-advised funds, charitable remainder trusts
- Calculate estate tax exposure and evaluate wealth transfer strategies
- Analyze income timing strategies for managing marginal tax bracket exposure
- Model impact of tax legislation changes on client wealth planning strategies
- Generate tax optimization reports with projected tax savings quantification

## Procedure

1. Extract client portfolio positions with cost basis, holding period, gain/loss status
2. Identify unrealized losses exceeding minimum threshold for harvesting
3. Screen for replacement securities maintaining factor exposure without wash sales
4. Analyze asset location efficiency across taxable, IRA, Roth, and trust accounts
5. Model Roth conversion amounts optimizing for current tax bracket and future projections
6. Evaluate charitable giving vehicles based on client philanthropic goals and tax position
7. Calculate estate tax exposure under current exemption and project sunset impact
8. Generate comprehensive tax optimization plan with projected savings
9. Schedule implementation timeline coordinating with tax advisor and estate attorney

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
| **IRC Sections 1001, 1091, 1014** | Capital gains recognition, wash sale rules, and stepped-up basis |
| **IRC Section 408A** | Roth IRA conversion rules and five-year holding periods |
| **IRC Section 170** | Charitable contribution deduction rules and limitations |
| **IRC Section 2010** | Unified credit against estate and gift tax |

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

- **Companion Agent**: `@wealth-tax-optimizer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |