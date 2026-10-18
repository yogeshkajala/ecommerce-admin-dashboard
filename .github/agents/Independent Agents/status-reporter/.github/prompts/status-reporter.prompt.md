---
description: "Generate project status reports with RAG indicators, metrics, and executive summaries"
---
# Status Reporter Prompt

## Usage
```
@status-reporter <describe the report needed>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `project` | Project or sprint to report on | Yes |
| `period` | Reporting period: this sprint, this week, this month | No |
| `audience` | Report audience: team, management, executive | No |

## Example Invocations

### Sprint Status
```
@status-reporter Generate sprint status report for the banking portal team this sprint
```

### Executive Summary
```
@status-reporter Create an executive summary of the banking portal project: progress, risks, and blockers
```

### RAG Dashboard
```
@status-reporter Generate RAG status for all in-progress features: transfer, statements, notifications
```

## Tips
- Specify the audience level for appropriate detail (team vs executive)
- Include Jira project key for data-driven reporting
- Ask for risk highlights and action items for actionable reports
