---
description: "Use when planning releases, defining milestones, tracking feature readiness, or creating go-live checklists and rollback plans."
---

# Release Planning Standards

## Release Scope
- Define scope from product roadmap with stakeholder sign-off
- All features in scope must be Done (not In Progress) before release
- No feature enters release without passing all quality gates

## Milestones
| Milestone | Criteria |
|-----------|----------|
| Feature Freeze | All features code-complete, PR merged |
| Code Freeze | Only critical bug fixes allowed |
| UAT Complete | All acceptance criteria validated |
| Go-Live | Deployment prerequisites met, rollback tested |

## Feature Readiness Checklist
- [ ] Development complete (code merged to release branch)
- [ ] Unit tests passing (≥80% coverage)
- [ ] Functional tests passing (all ACs covered)
- [ ] Security scan clear (0 critical/high)
- [ ] Documentation updated (API docs, user guides)
- [ ] Performance validated (meets SLA targets)

## Release Notes
- Generated from completed stories in the release
- Include: new features, improvements, bug fixes, breaking changes
- Breaking changes must have migration guide

## Rollback Plan (MANDATORY for production)
- Document rollback trigger criteria (error rate > X%, response time > Yms)
- Test rollback procedure before go-live
- Maximum rollback time: 15 minutes
- Designate rollback decision-maker with authority to act

## Versioning
- Follow SemVer: MAJOR.MINOR.PATCH
- MAJOR: breaking changes
- MINOR: new features (backward compatible)
- PATCH: bug fixes only
