---
description: "Model Portfolio Builder skill -- Use when building and managing model portfolios for wealth management platforms including security selection, portfolio construction, model maintenance, and mass customization for advisor-managed portfolios."
---

# Model Portfolio Builder Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Model Portfolio Builder operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When constructing new model portfolios with target allocation and security selection
- When maintaining existing models with rebalancing, substitutions, and allocation changes
- When implementing tax-managed and ESG-integrated model variations
- When deploying model changes across large client base with trade generation
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Construct model portfolios with asset allocation, security selection, and weighting
- Build model variations for tax management, ESG integration, and risk tiers
- Implement sleeve-based construction for core/satellite and tax-aware models
- Generate model change trade orders for mass deployment across accounts
- Validate model compliance against investment policy and regulatory constraints
- Back-test model performance against benchmarks and peer strategies
- Track model dispersion across accounts to identify outlier accounts
- Generate model management reports for investment committee review

## Procedure

1. Define model investment mandate: objective, benchmark, risk parameters, constraints
2. Select asset classes and determine strategic allocation weights
3. Choose securities for each allocation sleeve: ETFs, mutual funds, or individual
4. Set position sizes with minimum/maximum constraints and rounding rules
5. Back-test model using historical data against relevant benchmark
6. Validate model against investment policy and regulatory compliance rules
7. Deploy model to portfolio management platform for account assignment
8. Generate model change instructions when rebalancing or making substitutions
9. Produce model performance attribution and dispersion analysis reports

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
| **SEC Marketing Rule** | Model portfolio performance presentation and advertising requirements |
| **GIPS** | Composite construction and model performance reporting |
| **Reg BI** | Best interest obligations when recommending model portfolios |
| **ERISA 3(38)** | Fiduciary investment management for retirement plan models |

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

- **Companion Agent**: `@model-portfolio-builder` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |