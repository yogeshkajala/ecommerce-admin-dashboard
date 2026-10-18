---
description: "Payment Gateway Validator skill -- Use when validating payment gateway configurations, testing payment processing flows (authorization, capture, settlement, chargeback), ensuring PCI DSS compliance, and verifying payment scheme rule adherence for Visa, Mastercard, and other networks."
---

# Payment Gateway Validator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Payment Gateway Validator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When validating payment gateway integration and configuration
- When testing end-to-end payment flows including 3DS authentication
- When verifying PCI DSS compliance for cardholder data handling
- When checking payment scheme compliance for Visa and Mastercard rules
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Validate payment gateway API integration for authorization, capture, void, and refund
- Test 3-D Secure 2.0 authentication flows including frictionless and challenge paths
- Verify cardholder data encryption in transit and at rest per PCI DSS requirements
- Check tokenization implementation for recurring payment and card-on-file scenarios
- Validate settlement file reconciliation between gateway, processor, and bank
- Test chargeback and dispute handling workflows with scheme-specific reason codes
- Verify payment scheme mandate compliance (Visa VCR, MC Ethoca, dispute pre-arbitration)
- Generate PCI DSS self-assessment questionnaire evidence documentation

## Procedure

1. Review payment gateway configuration and API credential management
2. Execute test transactions across all payment methods and card types
3. Validate 3DS 2.0 authentication flow with various card enrollment scenarios
4. Verify cardholder data environment scope and PCI DSS control implementation
5. Test settlement batch processing and reconciliation accuracy
6. Execute chargeback simulation with representment and pre-arbitration
7. Validate payment scheme rule compliance for cross-border and multi-currency
8. Generate compliance report with findings categorized by severity
9. Produce remediation roadmap for any identified compliance gaps

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
| **PCI DSS v4.0** | Payment card industry data security standard controls |
| **EMV 3DS 2.0** | Strong customer authentication for card-not-present transactions |
| **ISO 8583** | Financial transaction card message interchange specification |
| **Visa Core Rules** | Visa payment scheme operating regulations and mandates |
| **Mastercard Standards** | Mastercard network rules and compliance requirements |

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

- **Companion Agent**: `@payment-gateway-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |