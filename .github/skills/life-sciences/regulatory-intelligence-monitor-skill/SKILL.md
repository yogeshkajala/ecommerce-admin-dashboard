---
description: "Regulatory Intelligence Monitor skill -- Use when monitoring regulatory intelligence including new guidance documents, regulatory actions, competitive landscape regulatory events, and regulatory environment changes affecting pharmaceutical development and commercialization."
---

# Regulatory Intelligence Monitor Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Regulatory Intelligence Monitor operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When tracking new FDA/EMA guidance documents and draft guidances
- When monitoring regulatory actions: approvals, CRLs, safety communications
- When analyzing competitive product regulatory milestones and strategies
- When assessing regulatory environment changes affecting development programs
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Monitor FDA, EMA, PMDA, and other agency guidance publications
- Track regulatory actions: NDA/BLA approvals, complete response letters, safety alerts
- Analyze competitive product regulatory timelines and strategies
- Assess impact of new regulations on ongoing development programs
- Monitor advisory committee meetings and recommendations
- Track patent and exclusivity events affecting market competition
- Generate regulatory intelligence briefings for development teams
- Produce regulatory landscape reports for strategic planning

## Procedure

1. Configure monitoring for relevant regulatory agencies and therapeutic areas
2. Collect regulatory intelligence from agency websites, Federal Register, EMA publications
3. Categorize intelligence by impact: development program, submission strategy, labeling
4. Analyze competitive regulatory events: approvals, refusals, safety actions
5. Assess impact of new guidances on current development programs
6. Monitor advisory committee calendars and meeting outcomes
7. Track patent and exclusivity expiration affecting competitive landscape
8. Generate weekly regulatory intelligence digest for development teams
9. Produce quarterly regulatory landscape report for strategic planning committee

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
| **FDA Federal Register Notices** | Official FDA regulatory actions, guidances, and rule-making |
| **EMA Human Medicines** | EU regulatory decisions, guidances, and committee opinions |
| **ICH Quality Guidelines** | International harmonized pharmaceutical regulatory standards |
| **21 CFR Parts 300-399** | FDA drug regulatory framework and requirements |

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

- **Companion Agent**: `@regulatory-intelligence-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |