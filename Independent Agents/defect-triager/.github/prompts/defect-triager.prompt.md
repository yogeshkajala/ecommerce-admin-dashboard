---
description: "Triage defects: assign severity, priority, SLA targets, and routing recommendations"
---
# Defect Triager Prompt

## Usage
```
@defect-triager <describe the defect to triage>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `defect` | Defect description or Jira key | Yes |
| `reproduction` | Steps to reproduce or failing test | No |
| `impact` | Known user impact (number of users, workaround available) | No |

## Example Invocations

### Triage a Bug
```
@defect-triager Transfer endpoint adds money to sender instead of subtracting. All transfer users affected, no workaround.
```

### From Jira
```
@defect-triager Triage WOR-5: login page returns 500 for users with special characters in email
```

### Bulk Triage
```
@defect-triager Triage these 3 bugs and recommend priority order: WOR-6, WOR-7, WOR-8
```

## Tips
- Include reproduction steps for faster severity assessment
- Mention if there's a workaround (affects priority)
- Specify if you need SLA targets and team routing
