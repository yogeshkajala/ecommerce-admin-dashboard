---
description: "Liquidity Risk Assessor skill -- Use when assessing bank liquidity risk including Liquidity Coverage Ratio (LCR), Net Stable Funding Ratio (NSFR), contingency funding plan adequacy, and intraday liquidity monitoring per Basel III/IV requirements."
---

# Liquidity Risk Assessor Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Liquidity Risk Assessor operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When calculating LCR and NSFR for Basel III/IV compliance
- When assessing contingency funding plan adequacy under stress scenarios
- When monitoring intraday liquidity positions and payment timing risks
- When evaluating funding concentration risk and maturity mismatch
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Calculate Liquidity Coverage Ratio with HQLA classification and stress outflows
- Compute Net Stable Funding Ratio from available and required stable funding
- Model liquidity stress scenarios: idiosyncratic, market-wide, and combined
- Assess contingency funding plan trigger levels and available actions
- Monitor intraday liquidity positions across payment and settlement systems
- Analyze funding concentration by counterparty, product, and maturity band
- Calculate liquidity buffer adequacy for overnight and term horizons
- Generate Basel III liquidity disclosure reports (Pillar 3)

## Procedure

1. Classify assets into HQLA Level 1, 2A, and 2B with appropriate haircuts
2. Calculate 30-day net cash outflows under stress scenario assumptions
3. Compute LCR and compare against regulatory minimum (100%)
4. Determine available stable funding from liabilities and equity by tenor
5. Calculate required stable funding for assets and off-balance-sheet exposures
6. Compute NSFR and validate compliance with minimum requirement
7. Run contingency funding plan stress tests with escalating severity
8. Generate liquidity risk dashboard with key metrics and early warning indicators
9. Produce regulatory submission-ready liquidity reports

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
| **Basel III LCR** | Liquidity Coverage Ratio calculation and minimum requirements |
| **Basel III NSFR** | Net Stable Funding Ratio for structural liquidity |
| **BCBS 248** | Monitoring tools for intraday liquidity management |
| **Federal Reserve Reg YY** | Enhanced prudential standards for liquidity risk management |

## Anti-Hallucination Rules

- Do not fabricate regulatory citations -- verify all statute and regulation references
- Do not assume institution-specific policies without explicit documentation
- Do not generate synthetic financial data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include implementation feasibility assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@liquidity-risk-assessor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |