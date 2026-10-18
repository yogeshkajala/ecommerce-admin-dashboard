---
name: code-reviewer-skill
description: "Code Reviewer skill -- Use when reviewing code for correctness, security vulnerabilities (OWASP Top 10), performance anti-patterns, and coding standards compliance."
---

# Code Reviewer Skill

**Category:** Generic Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for code review operations. This skill encapsulates security review patterns, performance analysis, and coding standards enforcement.

## When to Use

- When reviewing code for correctness, logic errors, and edge cases
- When checking for OWASP Top 10 security vulnerabilities
- When identifying performance anti-patterns (N+1 queries, memory leaks)
- When verifying coding standards and convention compliance
- When assessing error handling completeness and testability

## Capabilities

- Review for correctness: logic errors, off-by-one, null safety, concurrency bugs
- Check for OWASP Top 10 security vulnerabilities (injection, XSS, SSRF, etc.)
- Identify performance anti-patterns: N+1 queries, unbounded loops, memory leaks
- Verify coding standards compliance (auto-detect project linter/formatter conventions)
- Check error handling completeness and structured logging
- Assess code testability and dependency injection readiness
- Detect code smells: high complexity, duplication, god classes

## Review Checklist

1. **Correctness**: Does the code do what the requirements specify?
2. **Security**: Any OWASP Top 10 vulnerabilities?
3. **Performance**: Any N+1 queries, unnecessary allocations, blocking I/O?
4. **Readability**: Clear naming, appropriate abstractions, no magic numbers?
5. **Error Handling**: All failure paths handled? Appropriate error messages?
6. **Testing**: Is the code testable? Are dependencies injectable?
7. **Dependencies**: Any unnecessary or vulnerable dependencies?

## Finding Severity

| Severity | Definition | Example |
|----------|-----------|---------|
| Critical | Security vulnerability or data loss risk | SQL injection, exposed secrets |
| High | Functional defect or performance issue | Wrong business logic, N+1 query |
| Medium | Maintainability or minor performance issue | High complexity, code duplication |
| Low | Style or convention deviation | Naming inconsistency, missing comment |

## Procedure

1. Receive code review request -- identify scope, files, and context
2. Read the code under review and related architecture documents
3. Check correctness against requirements and acceptance criteria
4. Scan for OWASP Top 10 security vulnerabilities
5. Identify performance anti-patterns and resource management issues
6. Verify coding standards and convention compliance
7. Assess error handling completeness across all failure paths
8. Classify findings by severity (Critical, High, Medium, Low)
9. Generate review report with actionable findings and fix suggestions

## Output Format

Return structured results:

- **Summary**: files reviewed, total findings by severity
- **Findings**: ID, severity, file, line, description, suggested fix
- **Security Assessment**: OWASP category, CWE mapping, risk level
- **Recommendations**: improvement suggestions with priority
- **Quality Gate**: PASS/FAIL (0 Critical/High findings required to pass)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **OWASP Top 10** | Web application security risks -- injection, XSS, SSRF, etc. |
| **CWE/SANS Top 25** | Most dangerous software weaknesses with mitigations |
| **CERT Coding Standards** | Secure coding rules for C, C++, Java, Python |
| **SonarQube Rules** | Code quality rules -- bugs, vulnerabilities, code smells |
