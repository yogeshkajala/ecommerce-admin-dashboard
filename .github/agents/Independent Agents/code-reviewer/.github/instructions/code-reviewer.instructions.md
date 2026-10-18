---
description: "Use when reviewing code for quality, correctness, security, and performance. Defines review standards and severity classifications."
applyTo: "**/*.{py,js,ts,html}"
---

# Code Review Standards

## Full-Stack Integration Review (CRITICAL)
For full-stack projects, every review MUST check cross-layer consistency:
- **Frontend ↔ Backend contract**: Every frontend API call URL must have a matching backend route
- **URL path matching**: No trailing slash mismatches between frontend calls and backend routes
- **HTTP method matching**: Frontend call method (GET/POST/PUT/DELETE) must match backend handler method
- **Request/response fields**: Field names must be identical between frontend and backend
- **Component registration**: New files must be registered in the app entry points (imports, script tags, route configs)

If any mismatch is found, classify as **High** severity (functional defect — causes "Method Not Allowed" or 404 at runtime).

## Review Scope
- Every code change requires review before merge
- Review for: correctness, security, performance, readability, testability
- Maximum review size: 400 lines of logic (split larger PRs)

## Severity Classification
| Severity | Action | Example |
|----------|--------|---------|
| Critical | Block merge | SQL injection, exposed secrets, data loss |
| High | Block merge | Wrong business logic, N+1 queries, race conditions |
| Medium | Fix before next sprint | High complexity, duplication, missing error handling |
| Low | Optional | Naming nits, minor style, missing comments |

## Quality Gate
- 0 Critical findings required to pass
- 0 High findings required to pass
- All Medium findings must have a tracking ticket

## Review Checklist
1. Does the code correctly implement the requirements?
2. Are there any OWASP Top 10 security vulnerabilities?
3. Are all error paths handled with appropriate responses?
4. Are there N+1 queries, unbounded loops, or memory leaks?
5. Is the code testable with injectable dependencies?
6. Are naming and abstractions clear and consistent?
7. Is input validated at all system boundaries?
8. **Do backend route paths match frontend API calls exactly?** (trailing slashes, method types, path params)
9. **Are new patterns consistent with existing codebase conventions?** (route decorators, model structure, error formats)

## Feedback Rules
- Always explain WHY something is a problem, not just WHAT
- Always provide a suggested fix or alternative
- Reference specific file and line numbers
- Be objective and constructive; review code, not the person
