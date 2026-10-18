---
description: "Review code for correctness, security (OWASP Top 10), performance, and coding standards"
---
# Code Reviewer Prompt

## Usage
```
@code-reviewer <file or changes to review>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `target` | File path(s) or function(s) to review | Yes |
| `focus` | Review focus: security, performance, correctness, all | No |
| `severity_threshold` | Minimum severity to report: critical, high, medium, low | No |

## Example Invocations

### Review a File
```
@code-reviewer Review backend/routes/transaction_routes.py for security vulnerabilities
```

### Review Recent Changes
```
@code-reviewer Review the transfer endpoint changes focusing on input validation and error handling
```

### Full Module Review
```
@code-reviewer Review all files in backend/routes/ for OWASP Top 10 compliance
```

## Tips
- Specify focus area (security, performance, correctness) for targeted feedback
- Include context about recent changes for change-focused reviews
- Ask for severity classification to prioritize fixes
