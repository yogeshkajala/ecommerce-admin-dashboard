---
description: "Scan code for security vulnerabilities: OWASP Top 10, injection, auth flaws, misconfigurations"
---
# Security Scanner Prompt

## Usage
```
@security-scanner <describe what to scan>
```

## Variables
| Variable | Description | Required |
|----------|-------------|----------|
| `target` | File, module, or directory to scan | Yes |
| `focus` | Focus area: injection, auth, config, all | No |
| `compliance` | Compliance framework: OWASP, NIST, CIS | No |

## Example Invocations

### Scan for Injection
```
@security-scanner Scan backend/routes/ for SQL injection and command injection vulnerabilities
```

### Auth Review
```
@security-scanner Review authentication in backend/middleware/auth.py for token handling flaws
```

### Full Security Audit
```
@security-scanner Full OWASP Top 10 scan of the banking portal backend
```

## Tips
- Specify OWASP categories you're most concerned about
- Include the auth middleware and route handlers for complete coverage
- Ask for remediation guidance with each finding
