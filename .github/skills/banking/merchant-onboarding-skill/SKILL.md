---
description: "Merchant Onboarding skill -- Use when managing merchant onboarding for card acquiring including KYB (Know Your Business) verification, risk assessment, underwriting, pricing, and ongoing merchant monitoring for compliance and fraud risk."
---

# Merchant Onboarding Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Merchant Onboarding operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When performing KYB verification and risk assessment for merchant applicants
- When underwriting merchant accounts with appropriate risk classification
- When setting merchant pricing including interchange-plus and tiered models
- When monitoring merchant activity for suspicious transaction patterns
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Perform KYB verification: business registration, beneficial owners, website review
- Classify merchant risk based on MCC, processing volume, chargeback history, and geography
- Underwrite merchant accounts with appropriate reserve and limit structures
- Set pricing structures: interchange-plus, tiered, or flat-rate models
- Monitor transaction patterns for suspicious activity and policy violations
- Track chargeback rates against Visa VDMP and Mastercard ECM thresholds
- Manage merchant reserves: rolling, up-front, and minimum balance requirements
- Generate merchant risk reports and portfolio health dashboards

## Procedure

1. Receive merchant application with business documentation
2. Perform KYB verification: secretary of state, EIN, beneficial ownership
3. Conduct website compliance review for prohibited content and disclosure requirements
4. Classify merchant MCC code and assign risk tier
5. Calculate processing limits and reserve requirements based on risk assessment
6. Configure pricing structure per approved terms
7. Activate merchant account and distribute terminal/gateway credentials
8. Initiate post-onboarding monitoring with automated alert rules
9. Conduct 90-day post-activation review of actual vs projected activity

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
| **Visa Acquirer Risk Program** | Visa merchant monitoring and risk management requirements |
| **Mastercard Merchant Monitoring** | Mastercard acquirer obligations for merchant oversight |
| **BSA/AML** | Anti-money laundering requirements for merchant acquiring |
| **PCI DSS v4.0** | Merchant payment card data security validation requirements |

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

- **Companion Agent**: `@merchant-onboarding` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |