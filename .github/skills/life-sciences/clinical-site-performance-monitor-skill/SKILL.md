---
description: "Clinical Site Performance Monitor skill -- Use when monitoring clinical trial site performance including enrollment rates, data quality metrics, protocol compliance, query resolution times, and site risk assessment for clinical operations management."
---

# Clinical Site Performance Monitor Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Clinical Site Performance Monitor operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When monitoring site enrollment rates against projections and targets
- When assessing site data quality through query rates and error patterns
- When evaluating protocol compliance across clinical trial sites
- When performing risk-based monitoring with site risk scoring
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Track site enrollment metrics: screening rate, screen failure rate, randomization rate
- Monitor data quality indicators: query rate, query open time, CRF completion timeliness
- Assess protocol compliance: visit window adherence, procedure completion, consent compliance
- Calculate site risk scores using composite of quality, enrollment, and compliance metrics
- Compare site performance against study average and peer sites
- Identify at-risk sites requiring intervention or additional support
- Track monitoring visit findings and corrective action implementation
- Generate site performance dashboards for clinical operations oversight

## Procedure

1. Extract site performance data from EDC, CTMS, and monitoring reports
2. Calculate enrollment metrics by site against projected timelines
3. Analyze data quality indicators: query rates, error patterns, timeliness
4. Assess protocol compliance using key compliance indicators
5. Calculate composite site risk score from multiple performance dimensions
6. Rank sites by performance identifying high-risk and high-performing sites
7. Generate site-specific action plans for underperforming sites
8. Schedule targeted monitoring visits for high-risk sites
9. Produce site performance report for clinical operations review

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
| **ICH E6(R2)** | GCP requirements for clinical monitoring and site oversight |
| **FDA Risk-Based Monitoring Guidance** | FDA guidance on risk-based approach to clinical trial monitoring |
| **EMA GCP Inspections** | EU GCP inspection expectations for site oversight |
| **TransCelerate RBM** | Risk-based quality management system for clinical trials |

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

- **Companion Agent**: `@clinical-site-performance-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |