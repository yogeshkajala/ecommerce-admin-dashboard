---
description: "Use when performing security scanning, reviewing code for vulnerabilities, or implementing security controls. Covers OWASP Top 10 compliance."
---

# Security Standards

## OWASP Top 10 Compliance (MANDATORY)

### A01: Broken Access Control
- Deny by default; require explicit grants
- Enforce ownership checks on all resource access
- Disable directory listing; restrict CORS origins

### A02: Cryptographic Failures
- Use TLS 1.2+ for all data in transit
- Use AES-256 for data at rest encryption
- Never store passwords in plaintext; use bcrypt/argon2
- Rotate secrets and keys on a defined schedule

### A03: Injection
- Parameterize ALL database queries (never string concatenation)
- Validate and sanitize all input at system boundaries
- Use allowlists over denylists for input validation
- Escape output based on context (HTML, JS, SQL, OS command)

### A04: Insecure Design
- Implement rate limiting on auth endpoints
- Use CAPTCHA for public-facing forms
- Design with least privilege principle

### A05: Security Misconfiguration
- Remove default credentials and sample apps
- Disable stack traces in production error responses
- Set security headers: CSP, X-Frame-Options, HSTS

### A06: Vulnerable Components
- Pin all dependency versions
- Scan dependencies weekly for known CVEs
- Remove unused dependencies

### A07: Authentication Failures
- Enforce strong password policy (min 12 chars, complexity)
- Implement account lockout after 5 failed attempts
- Use multi-factor authentication for privileged accounts

### A08: Data Integrity Failures
- Verify integrity of all downloaded dependencies (checksums)
- Sign all deployment artifacts
- Validate CI/CD pipeline integrity

### A09: Logging Failures
- Log all authentication events (success and failure)
- Log access control failures and input validation failures
- Never log sensitive data (passwords, tokens, PII)
- Use structured logging with correlation IDs

### A10: SSRF
- Validate and sanitize all URLs from user input
- Use allowlists for external service calls
- Block requests to internal/private IP ranges from user input
