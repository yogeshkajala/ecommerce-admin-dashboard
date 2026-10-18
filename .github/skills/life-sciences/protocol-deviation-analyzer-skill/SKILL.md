---
description: "Protocol Deviation Analyzer skill -- Use when analyzing clinical trial protocol deviations including deviation classification, trend analysis, root cause patterns, impact assessment on data integrity, and corrective action tracking for GCP compliance."
---

# Protocol Deviation Analyzer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Protocol Deviation Analyzer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When classifying protocol deviations by type, severity, and impact
- When analyzing deviation trends across sites and study visits
- When assessing deviation impact on data integrity and subject safety
- When tracking corrective actions for recurring deviation patterns
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Classify deviations by type: inclusion/exclusion, visit window, procedure, consent, safety reporting
- Assess deviation severity: critical, major, minor per impact on data and safety
- Trend deviations by site, type, and time period for pattern identification
- Analyze root causes using 5-why and pattern recognition across similar deviations
- Assess impact of deviations on per-protocol analysis population and data integrity
- Track corrective actions and preventive measures implementation
- Generate deviation summaries for regulatory submission (CTD Section 2.7.3)
- Produce deviation analytics dashboards for study team and quality oversight

## Procedure

1. Receive protocol deviation report from site, monitor, or automated EDC detection
2. Classify deviation by type using standardized deviation taxonomy
3. Assess severity: critical (affects safety or data integrity), major, minor
4. Determine if deviation is reportable to IRB/EC or regulatory authority
5. Perform root cause analysis for significant and recurring deviations
6. Assess impact on subject: safety, efficacy evaluation, analysis population inclusion
7. Implement corrective action and preventive measures
8. Trend deviations for pattern detection across sites and time periods
9. Generate deviation summary report for study closeout and regulatory submission

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
| **ICH E6(R2)** | GCP protocol deviation handling and reporting requirements |
| **21 CFR 312.66** | FDA requirements for reporting protocol deviations in IND studies |
| **FDA Guidance on Protocol Deviations** | FDA approach to evaluation of protocol deviations in clinical trials |
| **EU Clinical Trials Regulation Article 52** | EU reporting requirements for protocol deviations |

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

- **Companion Agent**: `@protocol-deviation-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |