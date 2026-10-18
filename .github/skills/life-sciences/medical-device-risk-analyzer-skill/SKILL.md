---
description: "Medical Device Risk Analyzer skill -- Use when performing risk analysis for medical devices including FMEA, fault tree analysis, hazard analysis, risk-benefit assessment, and ISO 14971 risk management documentation for device design and manufacturing."
---

# Medical Device Risk Analyzer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Medical Device Risk Analyzer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When performing FMEA for medical device design and process risk analysis
- When conducting fault tree analysis for device failure mode investigation
- When creating risk management files per ISO 14971 requirements
- When assessing residual risk acceptability and benefit-risk balance
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Conduct Design FMEA analyzing device failure modes, effects, and controls
- Perform Process FMEA for manufacturing process risk assessment
- Execute fault tree analysis for complex device failure investigations
- Create hazard analysis linking hazards to hazardous situations and harms
- Assess risk using probability-severity matrix per ISO 14971
- Evaluate risk control effectiveness and residual risk acceptability
- Document risk management activities in ISO 14971-compliant risk management file
- Generate risk analysis reports for design review and regulatory submission

## Procedure

1. Define device scope and intended use for risk analysis boundary
2. Identify hazards and hazardous situations per ISO 14971 systematic approach
3. Conduct FMEA: list failure modes, determine effects, estimate severity and probability
4. Evaluate current risk controls and their effectiveness
5. Calculate risk level using probability-severity matrix
6. Determine if risk is acceptable, ALARP, or unacceptable per acceptability criteria
7. Implement additional risk controls for unacceptable risks
8. Evaluate residual risk after risk control implementation
9. Compile risk management file with all analyses, evaluations, and decisions

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
| **ISO 14971** | Medical devices risk management process requirements |
| **IEC 60812** | Failure mode and effects analysis methodology |
| **IEC 61025** | Fault tree analysis methodology for reliability |
| **21 CFR 820.30** | FDA QSR design control risk analysis requirements |

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

- **Companion Agent**: `@medical-device-risk-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |