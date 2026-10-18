---
description: "Mobile Banking Tester skill -- Use when testing mobile banking applications for functionality, security, performance, accessibility, and regulatory compliance including biometric authentication, remote deposit capture, and payment features."
---

# Mobile Banking Tester Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Mobile Banking Tester operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When testing mobile banking application functionality across platforms (iOS, Android)
- When validating biometric authentication and device binding security
- When testing remote deposit capture including image quality and check processing
- When verifying mobile payment features: P2P, bill pay, card controls
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Execute functional testing across account management, transfers, and payments
- Validate biometric authentication: Face ID, Touch ID, fingerprint, and fallback flows
- Test remote deposit capture with image quality validation and duplicate detection
- Verify push notification delivery for alerts, OTP, and transaction confirmations
- Test offline mode behavior and data synchronization on reconnection
- Validate accessibility compliance: VoiceOver, TalkBack, dynamic text sizing
- Perform security testing: certificate pinning, root/jailbreak detection, data storage
- Generate mobile banking test report with device/OS coverage matrix

## Procedure

1. Define test scope covering device matrix, OS versions, and feature areas
2. Execute functional test cases for all mobile banking features
3. Test biometric authentication enrollment, verification, and failure handling
4. Validate remote deposit capture with various check types and amounts
5. Verify P2P payment flows with recipient enrollment and delivery options
6. Test push notification delivery, rendering, and deep linking
7. Perform security assessment: traffic interception, data at rest, session management
8. Validate WCAG 2.1 AA accessibility compliance on both platforms
9. Generate comprehensive test report with pass/fail by feature and device

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
| **OWASP MASVS** | Mobile Application Security Verification Standard |
| **WCAG 2.1 AA** | Accessibility guidelines for mobile application interfaces |
| **FFIEC Mobile Banking Guidance** | Regulatory guidance on mobile banking risk management |
| **Check 21 Act** | Remote deposit capture and check image requirements |

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

- **Companion Agent**: `@mobile-banking-tester` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |