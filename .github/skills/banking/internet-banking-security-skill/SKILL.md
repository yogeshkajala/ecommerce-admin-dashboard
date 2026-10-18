---
description: "Internet Banking Security skill -- Use when assessing and hardening internet banking platform security including authentication mechanisms, session management, transaction signing, and compliance with FFIEC Authentication Guidance."
---

# Internet Banking Security Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Internet Banking Security operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When assessing internet banking authentication against FFIEC guidance
- When testing transaction signing and out-of-band verification mechanisms
- When validating session management and timeout policies
- When evaluating fraud detection integration with online banking platform
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Assess multi-factor authentication implementation per FFIEC guidance
- Test transaction signing mechanisms: hardware tokens, push notification, SMS OTP
- Validate session management: timeout, concurrent session, and re-authentication
- Evaluate adaptive authentication and risk-based step-up controls
- Test account lockout, recovery, and re-enrollment security flows
- Assess cross-site scripting, CSRF, and injection vulnerability protections
- Validate API security for mobile-to-server and third-party integrations
- Generate internet banking security assessment report with risk ratings

## Procedure

1. Review authentication architecture: factors, channels, and risk assessment
2. Test MFA enrollment, verification, and recovery workflows
3. Validate session management policies: idle timeout, absolute timeout, concurrent sessions
4. Assess transaction signing for high-risk operations (wire, ACH, payee management)
5. Test adaptive authentication rules and risk-based challenge triggers
6. Execute vulnerability assessment: OWASP Top 10, business logic flaws
7. Validate API security: authentication, authorization, rate limiting, input validation
8. Assess fraud detection integration and real-time alerting capabilities
9. Generate security assessment report with findings, risk ratings, and remediation

## Output Format

Return structured results:

- **Executive Summary: key findings, risk level, compliance status, recommended actions**
- **Detailed Analysis: line-by-line assessment results with evidence references**
- **Regulatory Mapping: applicable regulations, specific sections, compliance status**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **FFIEC Authentication Guidance** | Authentication and access to internet-based financial services |
| **OWASP ASVS v4.0** | Application Security Verification Standard for web banking |
| **NIST SP 800-63B** | Digital identity authentication assurance levels |
| **PCI DSS v4.0** | Security requirements for payment card data in online banking |

## Anti-Hallucination Rules

- Do not fabricate regulatory citations -- verify all statute and regulation references
- Do not assume institution-specific policies without explicit documentation
- Do not generate synthetic financial data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include implementation feasibility assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@internet-banking-security` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |