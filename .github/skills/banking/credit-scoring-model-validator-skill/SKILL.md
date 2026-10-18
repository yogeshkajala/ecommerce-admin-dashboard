---
description: "Credit Scoring Model Validator skill -- Use when performing independent model validation for credit scoring models per SR 11-7 guidance, assessing model conceptual soundness, testing discriminatory power, and evaluating ongoing model performance monitoring."
---

# Credit Scoring Model Validator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Credit Scoring Model Validator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When validating new credit scoring models before deployment
- When performing annual model validation reviews per SR 11-7
- When testing model discriminatory power, calibration, and stability
- When assessing fair lending model risk through disparate impact testing
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Assess model conceptual soundness: theory, methodology, and assumptions
- Test discriminatory power using Gini coefficient, KS statistic, and AUC-ROC
- Evaluate calibration accuracy: predicted vs observed default rates by segment
- Perform Population Stability Index analysis for input and output distributions
- Execute sensitivity analysis on key model variables and assumptions
- Conduct disparate impact testing for prohibited basis characteristics
- Validate model implementation: code review, parallel run, and UAT
- Generate model validation report with MRM rating and findings

## Procedure

1. Review model documentation: development paper, methodology, and assumptions
2. Assess conceptual soundness of modeling approach and variable selection
3. Replicate model using independent implementation for verification
4. Calculate discriminatory power metrics: Gini, KS, AUC, CAP
5. Test calibration by comparing predicted probabilities to actual outcomes
6. Perform stability analysis using PSI for population and input drift
7. Execute sensitivity analysis varying key inputs and assumptions
8. Conduct fair lending analysis checking for disparate impact
9. Generate comprehensive model validation report with MRM rating
10. Present findings to model risk management committee

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
| **SR 11-7 / OCC 2011-12** | Federal Reserve/OCC model risk management guidance |
| **ECOA (Reg B)** | Fair lending model testing requirements |
| **Basel III IRB** | Model requirements for internal ratings-based capital calculations |
| **CECL (ASC 326)** | Expected credit loss model validation requirements |

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

- **Companion Agent**: `@credit-scoring-model-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |