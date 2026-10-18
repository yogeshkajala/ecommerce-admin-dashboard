---
description: "Plan releases with milestones, readiness tracking, go-live checklists, and rollback plans"
---
# Release Planner Prompt

## Usage
```
@release-planner <describe the release to plan>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `release` | Release version or name | Yes |
| `features` | Features/epics included in the release | Yes |
| `target_date` | Target go-live date | No |

## Example Invocations

### Plan a Release
```
@release-planner Plan release v2.1.0 including transfer bug fix and statement export feature, target: next Friday
```

### Go-Live Checklist
```
@release-planner Generate a go-live checklist for deploying the banking portal v2.0 to production
```

### Rollback Plan
```
@release-planner Create a rollback plan for the database migration in release v2.1.0
```

## Tips
- Include all features and their test status for accurate readiness assessment
- Specify hard vs flexible deadlines for realistic scheduling
- Ask for rollback criteria (error rates, latency thresholds)
