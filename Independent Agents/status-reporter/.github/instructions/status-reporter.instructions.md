---
description: "Use when generating project status reports, RAG assessments, metrics dashboards, or executive summaries."
---

# Status Reporting Standards

## RAG Status Criteria
| Status | Criteria | Action |
|--------|----------|--------|
| 🟢 Green | On track, all gates passing, no blockers | Continue as planned |
| 🟡 Amber | Minor risks, 1-2 medium findings, mitigation underway | Monitor closely |
| 🔴 Red | Blocked, critical findings, timeline at risk | Escalate immediately |

## Report Structure (MANDATORY sections)
1. **Executive Summary**: 3-5 sentences, key decisions needed
2. **RAG Status**: overall + per-phase with justification
3. **Metrics**: coverage, velocity, defect density, acceptance rate
4. **Risks & Blockers**: description, impact, owner, mitigation
5. **Action Items**: item, owner, deadline, priority
6. **Next Steps**: what happens next, decisions required

## Metrics to Track
| Metric | Source | Target |
|--------|--------|--------|
| Code coverage | Unit test execution | ≥ 80% |
| Security findings | Security scan | 0 critical/high |
| Acceptance rate | Validation phase | 100% |
| Velocity trend | Sprint history | Stable or improving |
| Carry-over rate | Sprint completion | < 20% |

## Rules
- Every RAG status MUST have documented justification
- Red status MUST include escalation plan and timeline impact
- Metrics must come from actual tool output, never estimated
- Action items must have owner and deadline (no unassigned items)
- Reports must be audience-appropriate (executive vs. technical)

## Frequency
- Phase completion: automatic status update to Jira
- Weekly: consolidated status for stakeholders
- On-demand: when blockers or critical issues arise
