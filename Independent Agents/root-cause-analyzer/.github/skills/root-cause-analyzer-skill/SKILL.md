---
name: root-cause-analyzer-skill
description: "Root Cause Analyzer skill -- Use when performing root cause analysis on resolved incidents, building incident timelines, or generating preventive action items."
---
# Root Cause Analyzer Skill

## Purpose
Provides domain knowledge for performing post-incident root cause analysis, building event timelines, and generating preventive actions.

## When to Use
- When analyzing a resolved incident to prevent recurrence
- When building an incident timeline from logs and metrics
- When distinguishing contributing factors from true root cause
- When generating preventive action items with owners and deadlines

## Capabilities
- Build incident timelines from logs, metrics, alerts, and deployment records
- Apply 5 Whys analysis to trace symptoms to systemic root causes
- Distinguish contributing factors from the true root cause
- Identify technical failures (code, config, infra) and process gaps (review, monitoring)
- Generate preventive actions targeting systemic improvements
- Classify contributing factors: code defect, config error, process gap, monitoring blind spot

## Procedure
1. Define incident scope -- affected systems, duration, user impact
2. Build timeline -- collect events from logs, deploys, alerts, and communications
3. Identify trigger -- the specific event that initiated the incident
4. Apply 5 Whys -- trace from trigger through layers to systemic root cause
5. Identify contributing factors -- classify each as technical or process failure
6. Assess impact -- quantify users affected, duration, data impact, SLA breach
7. Generate preventive actions -- specific, assigned, with due dates and verification criteria
8. Document lessons learned -- what worked, what didn't, recommendations for similar systems

## Output Format
Return structured results:
- **Incident Summary**: what happened, when, who was affected, duration
- **Timeline**: chronological events with timestamps and sources
- **5 Whys Chain**: trigger → why₁ → why₂ → ... → systemic root cause
- **Contributing Factors**: classified list (code/config/process/monitoring)
- **Impact Assessment**: users affected, SLA breach, data impact
- **Preventive Actions**: action items with owner, due date, and verification criteria
- **Lessons Learned**: what worked well and what needs improvement

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **ITIL Problem Management** | Structured approach to eliminating recurring incidents |
| **SRE Postmortem Practice** | Blameless retrospectives with actionable follow-ups |
| **ISO 27035** | Information security incident management lifecycle |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER make recommendations without supporting evidence or analysis
- ALWAYS verify assumptions against actual system or codebase state
