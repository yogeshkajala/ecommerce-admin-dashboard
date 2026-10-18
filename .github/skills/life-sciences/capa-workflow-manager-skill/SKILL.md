---
description: "CAPA Workflow Manager skill -- Use when managing Corrective and Preventive Action (CAPA) workflows in pharmaceutical quality systems including root cause analysis, action plan development, implementation tracking, and effectiveness verification."
---

# CAPA Workflow Manager Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for CAPA Workflow Manager operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When initiating CAPA from deviations, complaints, audit findings, or OOS results
- When developing CAPA action plans with root cause-based corrective and preventive actions
- When tracking CAPA implementation progress against target timelines
- When verifying CAPA effectiveness through predefined criteria and monitoring periods
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Initiate CAPA from multiple quality event sources with proper linkage
- Facilitate root cause analysis using 5-Why, fishbone, and fault tree methodologies
- Develop action plans distinguishing corrective (address cause) from preventive (prevent recurrence)
- Assign CAPA actions with responsible parties, target dates, and success criteria
- Track implementation progress with escalation for overdue actions
- Verify CAPA effectiveness using predefined criteria over monitoring period
- Manage CAPA extensions and re-openings with proper justification
- Generate CAPA metrics: open, overdue, effectiveness rate, cycle time

## Procedure

1. Receive CAPA initiation from quality event, audit finding, or management review
2. Document problem statement with scope and impact assessment
3. Conduct root cause analysis appropriate to problem complexity
4. Develop corrective actions addressing identified root cause(s)
5. Develop preventive actions addressing systemic vulnerabilities
6. Assign actions to responsible parties with realistic target completion dates
7. Track implementation progress with periodic status reviews
8. Verify effectiveness after implementation using predefined criteria
9. Close CAPA with complete documentation and lessons learned capture

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
| **21 CFR 820.90** | FDA QSR corrective and preventive action requirements for medical devices |
| **ICH Q10** | Pharmaceutical Quality System CAPA framework |
| **ISO 13485** | Medical devices quality management CAPA requirements |
| **FDA 483 Observations** | Common CAPA-related inspection observations and expectations |

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

- **Companion Agent**: `@capa-workflow-manager` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |