---
description: "Manufacturing Deviation Tracker skill -- Use when tracking manufacturing deviations in pharmaceutical production including deviation classification, root cause analysis, impact assessment, CAPA management, and trending analysis for continuous improvement."
---

# Manufacturing Deviation Tracker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Manufacturing Deviation Tracker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When documenting and classifying manufacturing deviations by severity and type
- When conducting root cause analysis using structured investigation methodologies
- When assessing deviation impact on product quality and regulatory compliance
- When tracking CAPA implementation and effectiveness verification
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Document manufacturing deviations with standardized classification system
- Classify deviations by severity: critical, major, minor and by type: process, equipment, personnel
- Conduct root cause analysis using fishbone, 5-why, and fault tree analysis
- Assess deviation impact on batch quality and product release decision
- Generate CAPA recommendations with target completion dates
- Track CAPA implementation progress and effectiveness verification
- Trend deviations by type, area, process, and root cause for pattern detection
- Generate deviation reports for quality review and management review meetings

## Procedure

1. Receive deviation notification from manufacturing floor or quality observation
2. Document deviation details: what, when, where, who, how discovered
3. Classify deviation severity: critical (patient safety), major (quality impact), minor
4. Conduct immediate containment actions for critical and major deviations
5. Perform root cause investigation using appropriate methodology
6. Assess impact on affected batch(es) and in-process/released product
7. Generate CAPA based on root cause with preventive and corrective actions
8. Track CAPA implementation through to effectiveness verification
9. Trend deviation data for management review and continuous improvement

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
| **21 CFR 211.192** | FDA production record review and deviation investigation requirements |
| **ICH Q10** | Pharmaceutical Quality System CAPA and deviation management |
| **EU GMP Chapter 1** | Quality management system deviation handling requirements |
| **ICH Q9** | Quality Risk Management for deviation impact assessment |

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

- **Companion Agent**: `@manufacturing-deviation-tracker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |