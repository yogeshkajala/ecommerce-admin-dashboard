---
description: "Card Processing Auditor skill -- Use when auditing card processing operations including issuing, acquiring, authorization routing, settlement, and interchange compliance for debit and credit card programs."
---

# Card Processing Auditor Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Card Processing Auditor operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When auditing card authorization and settlement processing accuracy
- When validating interchange qualification and fee optimization
- When reviewing card program compliance with network operating regulations
- When assessing card processing vendor performance and SLA adherence
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Audit authorization routing logic for optimal interchange qualification
- Validate settlement file accuracy between issuer, acquirer, and network
- Analyze interchange downgrade patterns and recommend qualification improvements
- Review card program parameters against Visa/Mastercard operating regulations
- Assess dual-message and single-message processing flow accuracy
- Validate Durbin Amendment routing compliance for regulated debit transactions
- Analyze chargeback and dispute rates against network thresholds
- Generate card processing audit report with findings and remediation plan

## Procedure

1. Extract card transaction data from authorization and settlement systems
2. Analyze authorization approval rates by card type, merchant category, and channel
3. Validate interchange qualification rates against optimal benchmarks
4. Check Durbin Amendment dual-network routing compliance for regulated debit
5. Review settlement file reconciliation between all parties in the transaction chain
6. Analyze chargeback rates against Visa VDMP and Mastercard ECM thresholds
7. Assess card processing SLA performance against contractual commitments
8. Generate audit findings report with severity classification and remediation timeline
9. Present findings to card program management with improvement roadmap

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
| **PCI DSS v4.0** | Card data security controls for issuing and acquiring |
| **Durbin Amendment (Reg II)** | Debit card interchange and routing requirements |
| **Visa Core Rules** | Visa network operating regulations for issuers and acquirers |
| **Mastercard Standards** | Mastercard network compliance requirements and thresholds |

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

- **Companion Agent**: `@card-processing-auditor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |