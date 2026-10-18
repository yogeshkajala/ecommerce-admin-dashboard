---
description: "Plan sprints with velocity analysis, capacity calculation, and backlog prioritization"
---
# Sprint Planner Prompt

## Usage
```
@sprint-planner <describe the sprint planning need>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `board` | Jira board ID or team name | Yes |
| `sprint_duration` | Sprint length in days (default: 14) | No |
| `constraints` | PTO, holidays, or capacity constraints | No |

## Example Invocations

### Plan Next Sprint
```
@sprint-planner Plan next sprint for board WOR. Team has 2 devs, 1 on PTO for 3 days.
```

### Forecast Delivery
```
@sprint-planner When will we complete the remaining 45 story points in the WOR backlog at current velocity?
```

### Analyze Velocity
```
@sprint-planner Analyze velocity trend for the last 5 sprints and flag carry-over patterns
```

## Tips
- Provide team PTO and holiday info for accurate capacity
- Ask for dependency risk flags on cross-team items
- Request carry-over analysis to identify systemic planning issues
