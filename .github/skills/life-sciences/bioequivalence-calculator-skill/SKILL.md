---
description: "Bioequivalence Calculator skill -- Use when calculating bioequivalence parameters for generic drug development including pharmacokinetic parameter calculation, statistical analysis per FDA guidance, and bioequivalence study report generation for ANDA submissions."
---

# Bioequivalence Calculator Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Bioequivalence Calculator operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When calculating pharmacokinetic parameters: Cmax, AUC0-t, AUC0-inf from plasma data
- When performing bioequivalence statistical analysis: 90% CI for GMR
- When designing bioequivalence studies: crossover, parallel, fed/fasted
- When generating bioequivalence study reports for ANDA submission
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Calculate pharmacokinetic parameters using non-compartmental analysis
- Perform bioequivalence statistical analysis: ANOVA, 90% confidence intervals
- Evaluate bioequivalence using 80-125% acceptance criteria for log-transformed data
- Design BE studies: sample size, crossover periods, washout, fed/fasted conditions
- Handle highly variable drugs using reference-scaled average bioequivalence
- Assess narrow therapeutic index drugs with tightened BE criteria
- Generate pharmacokinetic plots: concentration-time curves, individual profiles
- Produce bioequivalence study reports formatted for ANDA regulatory submission

## Procedure

1. Extract plasma concentration-time data from bioanalytical laboratory results
2. Calculate PK parameters: Cmax, Tmax, AUC0-t, AUC0-inf, t1/2 using NCA methods
3. Perform statistical analysis: ANOVA on log-transformed parameters
4. Calculate geometric mean ratios and 90% confidence intervals
5. Evaluate bioequivalence against acceptance criteria (80.00-125.00%)
6. Apply reference-scaled approach for highly variable drugs if applicable
7. Generate concentration-time plots: mean and individual profiles
8. Produce statistical tables and data listings per FDA format
9. Compile bioequivalence study report for ANDA submission package

## Output Format

Return structured results:

- **Executive Summary: key findings, compliance status, risk classification, recommended actions**
- **Detailed Analysis: line-by-line assessment with regulatory reference citations**
- **Regulatory Impact: applicable regulations, specific sections, compliance gap severity**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **FDA BE Guidance** | FDA guidance on bioavailability and bioequivalence studies for ANDAs |
| **EMA BE Guideline** | EU guideline on investigation of bioequivalence |
| **ICH M13** | Bioequivalence for immediate-release solid oral dosage forms |
| **21 CFR 320** | FDA bioavailability and bioequivalence requirements |

## Anti-Hallucination Rules

- Do not fabricate clinical data or study results -- use actual protocol and study records
- Do not assume regulatory requirements without verifying current published guidance
- Do not generate synthetic patient data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published FDA/EMA guidance
- Cross-check GxP compliance assertions against specific regulation sections
- Validate all clinical data references against actual study database records
- Ensure all recommendations include regulatory risk impact assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@bioequivalence-calculator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |