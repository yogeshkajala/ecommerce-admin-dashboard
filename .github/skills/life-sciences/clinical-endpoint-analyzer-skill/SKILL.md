---
description: "Clinical Endpoint Analyzer skill -- Use when analyzing clinical trial endpoints including primary/secondary endpoint selection rationale, surrogate endpoint validation, composite endpoint design, and endpoint assessment methodology for regulatory acceptance."
---

# Clinical Endpoint Analyzer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Clinical Endpoint Analyzer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When evaluating primary endpoint selection for clinical trial design
- When assessing surrogate endpoint validity for accelerated approval pathway
- When designing composite endpoints for cardiovascular and oncology trials
- When analyzing endpoint measurement methodology for regulatory acceptance
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Evaluate endpoint clinical relevance and regulatory acceptability by therapeutic area
- Assess surrogate endpoint evidence: biological plausibility, epidemiological data, clinical trial evidence
- Design composite endpoints with component analysis methodology
- Analyze patient-reported outcome (PRO) endpoint validation and content validity
- Evaluate endpoint sensitivity to treatment effect and measurement variability
- Model sample size implications for different endpoint selections
- Review endpoint assessment methodology: central review, adjudication, blinded assessment
- Generate endpoint strategy report with regulatory precedent analysis

## Procedure

1. Review therapeutic area regulatory guidance for accepted endpoints
2. Evaluate proposed primary endpoint against clinical meaningfulness criteria
3. Assess endpoint measurement properties: validity, reliability, responsiveness
4. Analyze surrogate endpoint evidence if accelerated approval pathway considered
5. Evaluate composite endpoint design with component contribution analysis
6. Review PRO instrument validation: content validity, psychometric properties
7. Model statistical power for candidate endpoints with estimated treatment effects
8. Compile regulatory precedent analysis for proposed endpoint strategy
9. Generate endpoint strategy recommendation report for clinical team

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
| **ICH E9(R1)** | Statistical principles including estimands framework for endpoint analysis |
| **FDA Clinical Endpoint Guidance** | FDA guidance on clinical trial endpoints by therapeutic area |
| **FDA PRO Guidance** | Patient-reported outcome measures guidance for labeling claims |
| **EMA Guidelines on Clinical Endpoints** | EU guidance on endpoint acceptability by disease area |

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

- **Companion Agent**: `@clinical-endpoint-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |