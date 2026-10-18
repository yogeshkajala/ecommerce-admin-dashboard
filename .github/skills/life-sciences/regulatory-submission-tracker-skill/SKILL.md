---
description: "Regulatory Submission Tracker skill -- Use when tracking regulatory submissions across global markets including submission timelines, agency interactions, approval milestones, post-approval commitments, and lifecycle management for pharmaceutical products."
---

# Regulatory Submission Tracker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Regulatory Submission Tracker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When tracking regulatory submission timelines across multiple markets
- When managing agency interactions: questions, clock stops, advisory committees
- When monitoring approval milestones and post-approval commitments
- When planning regulatory lifecycle activities: variations, supplements, renewals
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Track submission status across FDA, EMA, PMDA, and global regulatory agencies
- Monitor review timelines: PDUFA dates, Day 120/180 EU clock, conditional approvals
- Manage agency interaction tracking: questions, responses, meeting minutes
- Track post-approval commitments: PMR, PMC, conditions of approval
- Plan lifecycle activities: supplements, variations, renewals, periodic reports
- Monitor competitive regulatory events: approvals, CRLs, label changes
- Generate regulatory submission dashboards with milestone tracking
- Produce regulatory planning reports for portfolio management

## Procedure

1. Register new submission with all relevant details and target timelines
2. Track submission through agency review stages: acceptance, review, action
3. Monitor and manage agency questions with internal response coordination
4. Track clock stops and review extensions with updated timeline projections
5. Record agency decisions: approval, CRL, refusal with reasoning
6. Register post-approval commitments with deadlines and responsible parties
7. Plan lifecycle submissions: supplements, variations, annual reports
8. Monitor competitive regulatory milestones for strategic awareness
9. Generate submission tracking report for regulatory affairs management

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
| **PDUFA Review Goals** | FDA review timeline goals for NDA/BLA submissions |
| **EU Centralized Procedure** | EMA review timeline and procedural requirements |
| **ICH M4** | Common Technical Document format for global submission harmonization |
| **21 CFR Part 314/601** | FDA application requirements and post-approval obligations |

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

- **Companion Agent**: `@regulatory-submission-tracker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |