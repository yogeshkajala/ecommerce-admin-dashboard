---
name: security-scanner-skill
description: "Security Scanner skill -- Use when scanning code for security vulnerabilities, dependency CVEs, hardcoded secrets, and OWASP Top 10 compliance."
---

# Security Scanner Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Security Scanner operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When scanning code for security vulnerabilities (OWASP Top 10)
- When checking for injection flaws, auth bypasses, and misconfigurations
- When scanning dependencies for known CVEs and supply chain risks
- When assessing security posture before deployment

## Capabilities

- Scan for injection vulnerabilities: SQL injection, XSS, command injection, SSRF
- Detect authentication and authorization flaws: broken access control, session management
- Identify cryptographic failures: weak algorithms, exposed secrets, improper key management
- Scan dependencies for known CVEs using advisory databases (NVD, GitHub Advisory)
- Detect security misconfigurations: debug mode enabled, default credentials, open CORS
- Identify sensitive data exposure: PII in logs, unencrypted storage, missing TLS
- Assess input validation completeness at API boundaries
- Generate security findings with CWE/CVE references and remediation guidance

## Procedure

1. Receive scan request -- identify target files, modules, or full codebase scope
2. Identify technology stack and applicable security rules (auto-detect from project files)
3. Scan for injection vulnerabilities: parameterized queries, input sanitization
4. Check authentication/authorization: token validation, role checks, session handling
5. Scan for cryptographic issues: hardcoded secrets, weak hashing, missing encryption
6. Scan dependencies for known CVEs and license compliance issues
7. Check security configuration: debug flags, CORS policy, error disclosure
8. Classify findings by severity (Critical, High, Medium, Low) with CWE references
9. Generate remediation guidance for each finding with fix examples

## Output Format

Return structured results:

- **Summary**: operation performed, scope, and execution status
- **Findings**: issue ID, severity, file/location, description, remediation
- **Metrics**: quantitative measurements (coverage, complexity, performance, counts)
- **Quality Gate**: PASS/FAIL with gate criteria evaluation details
- **Recommendations**: prioritized improvement actions with effort estimates

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **OWASP Top 10** | Critical web/API security risks and mitigation strategies |
| **NIST CSF** | Cybersecurity framework: Identify, Protect, Detect, Respond, Recover |
| **CIS Benchmarks** | Configuration security baselines for platforms and cloud services |
| **MITRE ATT&CK** | Adversarial tactics, techniques, and procedures knowledge base |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER report tool output without actual execution evidence
- ALWAYS verify version compatibility before applying technology-specific patterns

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER bypass security checks or disable safety validations
- ALWAYS use the appropriate tool version matching the target environment
