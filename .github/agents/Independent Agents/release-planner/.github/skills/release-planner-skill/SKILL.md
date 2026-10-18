---
name: release-planner-skill
description: "Release Planner skill -- Use when planning releases, defining milestones, tracking feature readiness, generating release notes, or creating rollback plans."
---

# Release Planner Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for release planning operations. This skill encapsulates release scope management, milestone tracking, and go-live readiness assessment.

## When to Use

- When defining release scope from epic/feature backlog
- When creating release milestones with entry/exit criteria
- When tracking feature readiness across development stages
- When generating release notes from completed stories
- When creating rollback plans and go-live checklists

## Capabilities

- Define release scope from product roadmap and stakeholder input
- Create release milestones with entry/exit criteria
- Track feature readiness (development, testing, documentation)
- Generate release schedule with sprint-to-release mapping
- Create go-live checklist with deployment prerequisites
- Assess release risk based on feature maturity and test coverage
- Generate release notes from completed stories
- Create rollback plan with decision criteria

## Procedure

1. Define release scope from product roadmap and stakeholder input
2. Map features to sprints based on team velocity
3. Create milestones: feature freeze, code freeze, UAT, go-live
4. Define entry/exit criteria for each milestone
5. Track feature readiness status across development stages
6. Generate go-live checklist with all prerequisites
7. Assess release risk from test coverage and outstanding defects
8. Create rollback plan with decision criteria and tested procedures
9. Generate release notes from completed stories

## Output Format

Return structured results:

- **Release Summary**: version, scope, target date, risk level
- **Milestones**: name, date, entry criteria, exit criteria, status
- **Feature Readiness**: feature, dev status, test status, doc status
- **Go-Live Checklist**: item, owner, status, blocker (if any)
- **Rollback Plan**: trigger criteria, steps, estimated rollback time
- **Quality Gate**: PASS/FAIL (all exit criteria met for current milestone)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **SemVer** | Semantic versioning for release numbering |
| **ITIL Change Management** | Change advisory board, rollback procedures |
| **Continuous Delivery** | Release pipeline, feature flags, canary releases |
