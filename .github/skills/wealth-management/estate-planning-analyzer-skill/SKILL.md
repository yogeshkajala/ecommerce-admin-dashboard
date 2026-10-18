---
description: "Estate Planning Analyzer skill -- Use when analyzing estate plans for high-net-worth clients including estate tax calculation, trust structure evaluation, beneficiary designation review, and wealth transfer strategy optimization."
---

# Estate Planning Analyzer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Estate Planning Analyzer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When calculating estate tax exposure under current and projected exemption amounts
- When evaluating trust structures: revocable, irrevocable, GRAT, ILIT, QPRT, SLAT
- When reviewing beneficiary designations across retirement accounts and insurance policies
- When modeling wealth transfer strategies including gifting programs and dynasty trusts
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate gross estate, allowable deductions, and taxable estate value
- Model estate tax under current exemption (.61M/2024) and projected sunset scenarios
- Evaluate trust structure suitability: GRAT, ILIT, QPRT, SLAT, CRT, CLT
- Review and validate beneficiary designations across all accounts and policies
- Calculate generation-skipping transfer tax exposure and exemption allocation
- Model gifting strategies using annual exclusion and lifetime exemption
- Assess business succession planning with buy-sell agreements and valuations
- Generate estate planning analysis report for advisor and client review

## Procedure

1. Compile complete inventory of client assets with current valuations
2. Calculate gross estate including probate, non-probate, and trust assets
3. Apply allowable deductions: marital, charitable, debts, expenses
4. Calculate estate tax liability under current exemption and scheduled sunset
5. Review existing trust structures for alignment with current estate plan goals
6. Validate beneficiary designations for retirement accounts, life insurance, TOD/POD
7. Model wealth transfer scenarios: gifting program, GRAT, ILIT, SLAT
8. Assess GST tax exposure and optimize exemption allocation
9. Generate comprehensive estate planning report with recommended actions

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
| **IRC Chapter 11** | Federal estate tax computation and exemptions |
| **IRC Chapter 12** | Gift tax rules, annual exclusion, and lifetime exemption |
| **IRC Chapter 13** | Generation-skipping transfer tax provisions |
| **SECURE Act 2.0** | Required minimum distributions and beneficiary rules for inherited IRAs |

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

- **Companion Agent**: `@estate-planning-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |