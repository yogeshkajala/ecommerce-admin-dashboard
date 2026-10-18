---
description: "Use when performing root cause analysis on incidents, building timelines, applying 5 Whys, or generating preventive action items."
---
# Root Cause Analyzer -- Instructions

## Scope
Use when performing root cause analysis on resolved incidents, building incident timelines, or generating preventive action items.

## Guidelines
- Build a timeline of events from logs, metrics, and deployment records
- Apply 5 Whys analysis to trace from symptom to underlying systemic cause
- Distinguish contributing factors from the true root cause
- Identify both technical and process failures that allowed the incident
- Generate preventive actions that address the root cause, not just symptoms
- Never fabricate data -- use only verified timestamps, logs, and metrics

## Quality Standards
- RCA reports must include: incident timeline, impact assessment, 5 Whys chain, and action items
- Each action item must have an owner, due date, and verification criteria
- Contributing factors must be classified: code defect, config error, process gap, monitoring blind spot
- Preventive actions must target systemic improvements, not individual blame
- Reports must include lessons learned and recommendations for similar systems
