---
description: "Patient Recruitment Optimizer skill -- Use when optimizing clinical trial patient recruitment including enrollment forecasting, recruitment channel analysis, site feasibility assessment, and digital recruitment strategy for accelerating clinical trial timelines."
---

# Patient Recruitment Optimizer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Patient Recruitment Optimizer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When forecasting enrollment timelines for clinical trial planning
- When analyzing recruitment channel effectiveness and ROI
- When assessing site feasibility for patient recruitment potential
- When designing digital recruitment strategies for clinical trials
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Forecast enrollment timelines using site capacity and historical recruitment data
- Analyze recruitment channel effectiveness: referrals, advertising, EHR mining, social media
- Assess site feasibility based on eligible patient population and investigator capacity
- Design digital recruitment campaigns: social media, search, patient advocacy partnerships
- Model enrollment scenarios with different site activation and recruitment assumptions
- Track recruitment KPIs: cost per patient, screen-to-randomization ratio, cycle time
- Identify and address recruitment barriers at site and study level
- Generate recruitment optimization reports for clinical operations planning

## Procedure

1. Analyze protocol inclusion/exclusion criteria for target population size estimation
2. Assess site feasibility: eligible population, investigator experience, site capacity
3. Design multi-channel recruitment strategy: referrals, advertising, digital, partnerships
4. Forecast enrollment timeline using Monte Carlo simulation with site-level parameters
5. Monitor actual enrollment against forecast with variance analysis
6. Identify sites with enrollment challenges and implement targeted interventions
7. Evaluate recruitment channel performance: cost per patient, quality of referrals
8. Adjust recruitment strategy based on emerging enrollment patterns
9. Generate enrollment tracking report with updated forecast and recommendations

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
| **ICH E6(R2)** | GCP requirements for subject recruitment and informed consent |
| **21 CFR 50.25** | FDA informed consent elements for clinical trial recruitment |
| **FDCA Section 502** | Advertising requirements applicable to clinical trial recruitment materials |
| **GDPR (EU)** | Data protection requirements for patient identification and recruitment |

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

- **Companion Agent**: `@patient-recruitment-optimizer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |