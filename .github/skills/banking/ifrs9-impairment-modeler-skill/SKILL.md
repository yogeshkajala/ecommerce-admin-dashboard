---
description: "IFRS 9 Impairment Modeler skill -- Use when calculating expected credit loss (ECL) provisions under IFRS 9 including stage classification (performing, underperforming, non-performing), PD/LGD/EAD modeling, and macro-overlay adjustments."
---

# IFRS 9 Impairment Modeler Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for IFRS 9 Impairment Modeler operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When classifying financial instruments into IFRS 9 stages 1, 2, and 3
- When calculating 12-month and lifetime expected credit losses
- When calibrating PD, LGD, and EAD models for ECL estimation
- When applying forward-looking macroeconomic overlays to ECL calculations
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Classify instruments into Stage 1 (12-month ECL), Stage 2 (lifetime ECL), Stage 3 (credit-impaired)
- Apply Significant Increase in Credit Risk (SICR) criteria for stage migration
- Calculate point-in-time PD term structures for each stage
- Estimate LGD incorporating collateral, recovery rates, and downturn adjustments
- Model EAD for revolving facilities using credit conversion factors
- Apply multiple forward-looking macroeconomic scenarios with probability weighting
- Calculate ECL provisions with vintage, cohort, and individual assessment methods
- Generate IFRS 9 disclosure notes including sensitivity analysis and reconciliation

## Procedure

1. Assess each instrument for Significant Increase in Credit Risk since initial recognition
2. Classify instruments into Stage 1, 2, or 3 based on SICR and default criteria
3. Calculate point-in-time PD curves for 12-month and remaining lifetime horizons
4. Estimate LGD using historical recovery data with economic cycle adjustment
5. Determine EAD incorporating drawdown expectations for revolving facilities
6. Define macroeconomic scenarios (base, upside, downside) with probability weights
7. Calculate ECL for each scenario as PD x LGD x EAD x discount factor
8. Weight scenario ECLs by assigned probabilities
9. Generate provision reconciliation, stage migration analysis, and disclosure notes

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
| **IFRS 9** | Expected credit loss impairment model requirements |
| **IFRS 7** | Financial instruments disclosure requirements for ECL |
| **EBA Guidelines on IFRS 9** | European Banking Authority implementation guidance |
| **Basel III** | Interaction between accounting provisions and regulatory capital |

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

- **Companion Agent**: `@ifrs9-impairment-modeler` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |