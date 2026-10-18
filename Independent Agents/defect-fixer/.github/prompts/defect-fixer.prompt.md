---
description: "Fix defects with root cause analysis, minimal-impact patches, and regression tests"
---
# Defect Fixer Prompt

## Usage
```
@defect-fixer <describe the defect to fix>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `defect` | Defect description, Jira key, or failing test | Yes |
| `file` | File(s) suspected to contain the bug | No |
| `constraint` | Fix constraints: hotfix-only, no-schema-change, etc. | No |

## Example Invocations

### Fix a Bug
```
@defect-fixer Fix: transfer endpoint adds amount to sender balance instead of subtracting (backend/routes/transaction_routes.py)
```

### With Regression Test
```
@defect-fixer Fix WOR-3 and write a regression test proving the sender's balance decreases after transfer
```

### Root Cause First
```
@defect-fixer Diagnose why login fails for emails containing '+' and implement minimal fix
```

## Tips
- Point to the suspected file for faster diagnosis
- Ask for blast radius assessment before the fix is applied
- Request regression tests to be included with the fix
