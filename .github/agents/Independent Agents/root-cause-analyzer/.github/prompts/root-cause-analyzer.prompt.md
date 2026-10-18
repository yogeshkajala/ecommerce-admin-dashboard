---
description: "Perform root cause analysis on incidents with 5 Whys, timelines, and preventive actions"
---
# Root Cause Analyzer Prompt

## Usage
```
@root-cause-analyzer <describe the incident or failure>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `incident` | Description of the incident or failure | Yes |
| `logs` | Log files or error output | No |
| `timeline` | Known sequence of events | No |

## Example Invocations

### Analyze a Bug
```
@root-cause-analyzer The transfer endpoint is adding money to sender instead of subtracting. Trace root cause.
```

### Post-Incident RCA
```
@root-cause-analyzer Production was down for 30 mins after deploy at 14:00. Logs show connection pool exhaustion.
```

### Systematic Analysis
```
@root-cause-analyzer Apply 5 Whys to: users report seeing other users' transaction history after login
```

## Tips
- Include error logs, stack traces, or reproduction steps for better analysis
- Mention when the issue started and any recent changes
- Ask for preventive actions to get systemic improvement recommendations
