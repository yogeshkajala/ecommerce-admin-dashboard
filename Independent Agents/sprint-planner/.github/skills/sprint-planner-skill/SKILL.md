---
name: sprint-planner-skill
description: "Sprint Planner skill -- Use when planning sprints, analyzing team capacity and velocity, scoping sprint work, or forecasting delivery dates."
---

# Sprint Planner Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for sprint planning operations. This skill encapsulates velocity analysis, capacity planning, and backlog prioritization patterns.

## When to Use

- When planning sprint scope based on team velocity and capacity
- When analyzing historical velocity trends from closed sprints
- When calculating adjusted capacity factoring PTO and holidays
- When prioritizing backlog items for sprint inclusion
- When forecasting delivery dates for remaining backlog

## Capabilities

- Analyze team velocity from historical sprint data (minimum 3 sprints)
- Calculate team capacity factoring holidays, PTO, and focus percentage
- Recommend sprint scope based on velocity trend and adjusted capacity
- Prioritize backlog items using MoSCoW + dependency graph analysis
- Identify cross-team dependency risks that could block sprint items
- Forecast delivery dates based on current velocity
- Detect carry-over patterns and recommend corrective actions
- Generate sprint plan reports with confidence intervals

## Procedure

1. Retrieve last 5 closed sprints and calculate velocity metrics
2. Compute average, median, and trend (improving/stable/declining)
3. Identify team roster and check for PTO/holidays in sprint window
4. Calculate adjusted capacity: `avg_velocity × (available_days / sprint_days) × focus_factor`
5. Fetch and score prioritized backlog items
6. Select items fitting within capacity, respecting dependency order
7. Identify items with cross-team dependencies and flag as risks
8. Present sprint plan recommendation for approval
9. Generate sprint plan report with metrics and confidence level

## Output Format

Return structured results:

- **Sprint Summary**: name, goal, dates, capacity in story points
- **Velocity Metrics**: average, median, trend, carry-over rate
- **Recommended Items**: key, summary, story points, priority, risks
- **Dependency Risks**: item, blocked-by, team, mitigation
- **Delivery Forecast**: remaining backlog SP, sprints to complete, projected date
- **Quality Gate**: PASS/FAIL (recommended SP ≤ adjusted capacity)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **Scrum Guide** | Sprint planning ceremony, sprint goal, capacity-based planning |
| **SAFe PI Planning** | Program increment planning, dependency management |
| **Kanban Metrics** | Flow efficiency, cycle time, throughput forecasting |
