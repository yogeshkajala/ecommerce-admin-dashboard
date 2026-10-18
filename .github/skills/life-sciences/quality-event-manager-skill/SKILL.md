---
description: "Quality Event Manager skill -- Use when managing pharmaceutical quality events including complaints, deviations, OOS/OOT results, recalls, and regulatory observations with unified quality event lifecycle management and trending."
---

# Quality Event Manager Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Quality Event Manager operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When managing quality event lifecycle from initiation through closure
- When investigating product complaints and determining regulatory reporting requirements
- When managing OOS and OOT laboratory investigation procedures
- When coordinating product recall activities and regulatory notifications
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Manage unified quality event lifecycle: initiation, investigation, CAPA, closure
- Process product complaints with medical assessment and reporting determination
- Conduct OOS/OOT investigations per FDA guidance with Phase I and Phase II procedures
- Coordinate product recall: health hazard evaluation, recall classification, notifications
- Track regulatory observations (FDA 483, EU GMP non-compliance) through remediation
- Trend quality events for annual product quality review and management review
- Calculate quality metrics: event rates, investigation cycle times, CAPA effectiveness
- Generate quality event reports for regulatory inspection and management review

## Procedure

1. Receive quality event notification: complaint, deviation, OOS, regulatory observation
2. Document event details with initial risk assessment
3. Classify event type and severity for prioritization
4. Assign investigation team with appropriate subject matter expertise
5. Conduct investigation using structured methodology
6. Determine regulatory reporting requirements (MedWatch, field alert, recall)
7. Generate CAPA based on investigation findings
8. Track CAPA implementation and verify effectiveness
9. Close quality event with complete documentation and trending update

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
| **21 CFR 211.198** | FDA complaint handling requirements for pharmaceutical manufacturers |
| **21 CFR 211.160** | FDA OOS investigation requirements for laboratory testing |
| **21 CFR Part 7** | FDA enforcement policy and recall classification guidance |
| **ICH Q10** | Pharmaceutical Quality System quality event management |

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

- **Companion Agent**: `@quality-event-manager` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |