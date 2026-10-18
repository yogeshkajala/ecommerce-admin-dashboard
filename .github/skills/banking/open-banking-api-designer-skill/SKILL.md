---
description: "Open Banking API Designer skill -- Use when designing Open Banking APIs compliant with PSD2, FDX, and other open finance standards, implementing secure consent management, and enabling third-party provider access to banking data and payment initiation."
---

# Open Banking API Designer Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Open Banking API Designer operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When designing account information and payment initiation APIs per PSD2/Open Banking
- When implementing customer consent management for third-party data access
- When building secure TPP (Third Party Provider) onboarding and credential management
- When ensuring API security with OAuth 2.0, FAPI, and certificate-based authentication
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Design Account Information Service Provider (AISP) APIs per Berlin Group or UK OB specs
- Design Payment Initiation Service Provider (PISP) APIs with SCA enforcement
- Implement OAuth 2.0 / FAPI security profiles for API access control
- Build consent management APIs supporting granular permissions and revocation
- Design TPP onboarding workflows with eIDAS certificate validation
- Implement rate limiting, throttling, and API availability SLAs per regulatory requirements
- Generate API documentation conforming to OpenAPI 3.0 specification
- Produce API conformance test suites for regulatory certification

## Procedure

1. Analyze regulatory requirements for target jurisdiction (PSD2, CDR, FDX)
2. Design API resource model covering accounts, balances, transactions, payments
3. Implement FAPI-compliant security profile with PKCE and JAR
4. Build consent management with purpose limitation and time-bound access
5. Design TPP registration and certificate validation workflow
6. Implement rate limiting meeting minimum API availability requirements
7. Create comprehensive API documentation with examples and error codes
8. Execute conformance testing against regulatory certification test suite
9. Deploy APIs with monitoring, logging, and incident response procedures

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
| **PSD2 (EU)** | Payment Services Directive 2 open banking requirements |
| **UK Open Banking Standard** | UK API specifications for account and payment access |
| **FDX (Financial Data Exchange)** | US standard for financial data sharing APIs |
| **FAPI (Financial-grade API)** | OpenID Foundation security profile for financial APIs |

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

- **Companion Agent**: `@open-banking-api-designer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |