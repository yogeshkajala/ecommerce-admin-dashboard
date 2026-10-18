---
name: status-reporter-skill
description: "Status Reporter skill -- Use when generating project status reports with RAG indicators, metrics dashboards, risk summaries, and executive action items."
---

# Status Reporter Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for status reporting operations. This skill encapsulates RAG status frameworks, metrics collection, and executive summary generation.

## When to Use

- When generating project status reports for stakeholders
- When producing RAG (Red/Amber/Green) status assessments
- When summarizing phase progress across the feature lifecycle
- When creating executive summaries with metrics and risks
- When tracking action items and blockers across phases

## Capabilities

- Generate RAG status with documented justification for each indicator
- Collect and summarize metrics from all completed phases
- Identify and escalate blockers with mitigation proposals
- Create executive summaries suitable for stakeholder communication
- Track action items with ownership, deadlines, and status
- Produce trend analysis showing progress over time
- Highlight risks with impact assessment and recommended actions
- Format reports for different audiences (executive, technical, team)

## RAG Status Criteria

| Status | Criteria |
|--------|----------|
| 🟢 Green | On track, no blockers, all gates passing |
| 🟡 Amber | Minor risks, 1-2 medium findings, mitigation in progress |
| 🔴 Red | Blocked, critical findings, timeline at risk |

## Procedure

1. Collect status from all completed and in-progress phases
2. Gather metrics: coverage, findings count, velocity, acceptance rate
3. Assess overall RAG status based on criteria above
4. Identify top risks and blockers with mitigation status
5. Summarize key achievements since last report
6. List action items with owner, deadline, and priority
7. Generate executive summary (3-5 sentences, key decisions needed)
8. Format report for target audience

## Output Format

Return structured results:

- **Executive Summary**: 3-5 sentence overview with key decisions needed
- **RAG Status**: overall and per-phase with justification
- **Metrics Dashboard**: coverage, velocity, defect density, acceptance rate
- **Risks & Blockers**: description, impact, owner, mitigation, status
- **Action Items**: item, owner, deadline, priority, status
- **Quality Gate**: PASS/FAIL (no Red status without escalation plan)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **PMI Reporting** | Project status reporting, earned value metrics |
| **DORA Metrics** | Deployment frequency, lead time, MTTR, change failure rate |
| **OKR Framework** | Objectives and key results for progress tracking |
