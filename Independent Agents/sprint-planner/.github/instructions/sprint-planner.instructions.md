---
description: "Use when planning sprints, analyzing team velocity, calculating capacity, or scoping sprint work."
---

# Sprint Planning Standards

## Velocity Analysis
- Use minimum 3 (ideally 5) closed sprints for velocity calculation
- Track: average, median, and trend (improving/stable/declining)
- Monitor carry-over rate; flag if consistently > 20%

## Capacity Calculation
- Formula: `avg_velocity × (available_days / sprint_days) × focus_factor`
- Default focus factor: 0.8 (accounts for ceremonies, support, interrupts)
- Subtract PTO and holidays from available days
- Never plan above 85% of calculated capacity

## Sprint Scope Rules
- Sprint goal must be achievable and measurable
- Respect dependency ordering when selecting items
- Include buffer (10-15% of capacity) for unplanned work
- Maximum 1 high-risk item per sprint unless team is experienced

## Backlog Prioritization
- Score: `priority_weight × business_value / (story_points + dependency_risk)`
- Consider dependencies: don't pull items whose blockers aren't resolved
- Balance tech debt (20% of capacity) with feature work

## Anti-Patterns (NEVER do)
- Planning above team capacity ("stretch goals" without buffer)
- Ignoring carry-over patterns sprint after sprint
- Including items with unresolved external dependencies
- Changing sprint scope after sprint start without team agreement
