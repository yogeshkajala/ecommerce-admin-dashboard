---
description: "Investment Suitability Checker skill -- Use when validating investment recommendations against client suitability profiles per Reg BI (Best Interest), FINRA Rule 2111, and MiFID II suitability requirements including risk tolerance, time horizon, and financial situation."
---

# Investment Suitability Checker Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Investment Suitability Checker operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When validating investment recommendations against client risk profiles
- When assessing suitability of complex products: alternatives, structured notes, options
- When ensuring Reg BI best interest obligation compliance
- When documenting suitability rationale for client relationship reviews
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Match investment recommendations to client risk tolerance profiles
- Validate product complexity against client experience and sophistication level
- Assess liquidity needs alignment with recommended investment time horizons
- Check concentration limits relative to client total investable assets
- Evaluate cost reasonableness including fees, commissions, and expense ratios
- Validate alternative investment suitability: accredited investor, QP status
- Generate suitability documentation for supervisory review and audit trail
- Produce suitability exception reports with escalation to compliance

## Procedure

1. Extract client profile: risk tolerance, time horizon, liquidity needs, financial situation
2. Receive investment recommendation with product details and rationale
3. Match product risk characteristics to client risk tolerance band
4. Validate client qualifications for product type (accredited investor, QP, etc.)
5. Assess liquidity profile against minimum holding periods or lock-ups
6. Calculate cost impact including advisory fees, fund expenses, and transaction costs
7. Compare recommendation against available alternatives for best interest test
8. Generate suitability assessment report with pass/fail and rationale
9. Archive suitability documentation per recordkeeping requirements

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
| **Reg BI (SEC)** | Broker-dealer best interest obligation and care standard |
| **FINRA Rule 2111** | Suitability requirements for broker-dealer recommendations |
| **MiFID II Suitability** | EU investment suitability assessment requirements |
| **FINRA Rule 2090** | Know Your Customer obligations for investment accounts |

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

- **Companion Agent**: `@investment-suitability-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |