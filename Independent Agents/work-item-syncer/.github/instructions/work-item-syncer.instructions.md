---
description: "Use when interacting with Jira, updating tickets, managing sprints, or tracking work items."
---

# Jira Integration Standards

## Ticket Management
- Update ticket status after each phase completes
- Post status comment with pass/fail result on every gate evaluation
- Never proceed past Phase 0 without a valid Jira Story key
- Link related tickets (blocks, is-blocked-by, relates-to)

## Comment Format
- Use Markdown formatting in all Jira comments
- Include: phase name, status (PASS/FAIL), summary, key findings, next steps
- Use real line breaks in comment body (never literal `\n`)
- Prefix with status emoji: ✅ PASS, ❌ FAIL, ⚠️ BLOCKED

## Status Transitions
Apply transitions to **both** Epic and Story at each milestone.

### Story Transitions
| Trigger | Target Status |
|---------|---------------|
| Phase 0 complete | In Progress |
| Gate failure | Blocked + add `blocked` label |
| Phase 10 passes | In Review |
| Phase 11 passes | Done |

### Epic Transitions
| Trigger | Target Status |
|---------|---------------|
| Phase 0 complete | In Progress |
| Gate failure | Blocked + add `blocked` label |
| Phase 10 passes | In Review |
| Phase 11 passes | Done |

## Sprint Management
- Create sprint with meaningful name: `<project>-Sprint-<N>`
- Sprint duration: 2 weeks standard
- Add story to sprint immediately after creation
- Update story points after effort estimation phase

## Release Management
- Create fix version for each feature release
- Associate story with fix version after validation passes
- Update release notes after successful deployment
- Release version only after all stories are Done

## Labels
- Use `blocked` when a gate fails
- Use `in-review` during validation phase
- Use `deployed` after successful deployment
- Remove transitional labels when status changes
