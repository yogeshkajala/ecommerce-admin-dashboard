---
description: "Security Validator skill -- Use when validating application security including SAST, dependency scanning, secret detection, and OWASP Top 10 compliance."
---
# Security Validator Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Security Validator operations.

## When to Use
- When performing security tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Scan codebases and configurations for security vulnerabilities and misconfigurations
- Apply OWASP Top 10 and CWE classification to identified findings
- Evaluate access control policies against least-privilege and zero-trust principles
- Detect secrets, credentials, and sensitive data exposure in repositories
- Assess compliance posture against NIST, SOC2, ISO 27001, and PCI-DSS frameworks
- Generate security remediation plans with severity-based prioritization
- Review authentication and authorization flows for common weaknesses
- Produce security assessment reports with risk scores and remediation timelines

## Procedure
1. Receive security assessment request -- identify scope, assets, and applicable compliance frameworks
2. Scan target systems for vulnerabilities using SAST, DAST, and configuration analysis
3. Classify findings by severity (Critical, High, Medium, Low) using CVSS scoring
4. Map findings to OWASP Top 10, CWE categories, and applicable compliance controls
5. Assess exploitability and business impact for each finding
6. Generate remediation plan with prioritized actions, effort estimates, and fix guidance
7. Validate remediation effectiveness through re-scanning and verification testing
8. Produce security assessment report with findings, risk scores, and compliance status

## Output Format
Return structured results:
- **Risk Score**: overall security posture score (0-100) with severity breakdown
- **Findings**: CVE/CWE ID, severity, location, description, remediation guidance
- **Compliance Status**: framework, control ID, status (compliant/non-compliant/partial)
- **Remediation Plan**: prioritized actions with effort estimates and fix verification steps
- **Executive Summary**: critical findings count, risk trend, and recommended immediate actions

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **OWASP Top 10** | Critical web application security risks and mitigation strategies |
| **NIST CSF** | Cybersecurity framework -- Identify, Protect, Detect, Respond, Recover |
| **CIS Benchmarks** | Configuration security baselines for operating systems and cloud platforms |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER downgrade severity without documented justification
- ALWAYS verify vulnerability status against current CVE databases
