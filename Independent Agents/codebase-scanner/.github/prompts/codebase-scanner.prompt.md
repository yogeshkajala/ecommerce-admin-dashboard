---
description: "Scan codebase to identify files, functions, and modules affected by a proposed change"
---
# Codebase Scanner Prompt

## Usage
```
@codebase-scanner <describe the change to analyze impact for>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `change` | Description of the proposed change | Yes |
| `entry_points` | Starting files or functions to trace from | No |
| `depth` | Dependency traversal depth (default: 3) | No |

## Example Invocations

### Impact Analysis
```
@codebase-scanner What files are affected if I change the UserModel.update_balance() method?
```

### Trace Dependencies
```
@codebase-scanner Trace all callers of the /api/transfer endpoint and identify test coverage
```

### Config Impact
```
@codebase-scanner If I add a new database table, what config and migration files need updating?
```

## Tips
- Specify entry points for faster, more targeted scanning
- Ask for test file coverage to identify testing gaps
- Use before making changes to understand blast radius
