---
description: "Biomarker Data Analyzer skill -- Use when analyzing biomarker data from clinical trials including biomarker qualification, assay validation assessment, biomarker-endpoint correlation, and companion diagnostic development support for precision medicine."
---

# Biomarker Data Analyzer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Biomarker Data Analyzer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When analyzing biomarker data for patient stratification and enrichment
- When assessing biomarker assay analytical validation status
- When evaluating biomarker-endpoint correlation for surrogate endpoint qualification
- When supporting companion diagnostic development with clinical correlation data
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Analyze biomarker data: expression levels, cut-point determination, responder analysis
- Assess analytical validation: sensitivity, specificity, precision, reproducibility
- Evaluate biomarker-clinical endpoint correlation using statistical methods
- Support patient stratification and enrichment strategy based on biomarker data
- Model predictive and prognostic biomarker performance
- Assess companion diagnostic device-drug co-development requirements
- Generate biomarker analysis reports for regulatory submissions
- Produce biomarker strategy recommendations for clinical development planning

## Procedure

1. Extract biomarker data from clinical trial database and laboratory systems
2. Validate biomarker assay performance data: CV, linearity, sensitivity, specificity
3. Perform exploratory biomarker analysis: distribution, outliers, missing data patterns
4. Determine optimal cut-point using ROC analysis or clinical rationale
5. Analyze biomarker-endpoint correlation: predictive and prognostic assessment
6. Evaluate patient subgroup responses based on biomarker status
7. Assess companion diagnostic development pathway requirements
8. Generate biomarker analysis report with clinical and regulatory implications
9. Present findings to clinical development team for strategy decisions

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
| **FDA Biomarker Qualification** | FDA guidance on biomarker qualification for drug development |
| **ICH E16** | Biomarkers related to drug or biotechnology product development |
| **CLSI EP28** | Clinical Laboratory Standards Institute assay validation guidelines |
| **FDA Companion Diagnostic Guidance** | In vitro companion diagnostic device co-development requirements |

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

- **Companion Agent**: `@biomarker-data-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |