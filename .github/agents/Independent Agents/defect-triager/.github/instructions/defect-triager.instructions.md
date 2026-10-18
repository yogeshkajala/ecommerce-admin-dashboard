---
description: "Use when triaging defects, assigning severity and priority, determining SLA targets, or classifying defect categories."
---
# Defect Triager -- Instructions

## Scope
Use when triaging defects, assigning severity and priority, determining SLA targets, assessing user impact, or classifying defect categories.

## Guidelines
- Assess user impact: how many users affected, is there a workaround?
- Classify severity using CVSS-like scoring: data impact, availability, scope
- Assign priority based on severity + business context + SLA deadlines
- Check for duplicate or related existing issues before creating new tickets
- Escalate Critical/High severity defects immediately to the owning team
- Never fabricate data -- use only verified reproduction steps and logs

## Quality Standards
- Triage output must include: severity, priority, SLA target, affected component, and assignee recommendation
- Severity scale: Critical (P1, 4h SLA), High (P2, 24h), Medium (P3, 1 sprint), Low (P4, backlog)
- Each triage must document reproduction steps or link to failing test
- Duplicate detection must reference the original issue key
- Escalation criteria must be documented when defect crosses team boundaries
