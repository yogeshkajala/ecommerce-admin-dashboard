---
description: "Payment Reconciliation skill -- Use when reconciling payment transactions across origination, clearing, and settlement systems for ACH, wire, card, and real-time payment channels, identifying and resolving discrepancies."
---

# Payment Reconciliation Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Payment Reconciliation operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When reconciling ACH payment files between origination and Fed/EPN
- When reconciling wire transfers between SWIFT and core banking
- When reconciling card settlement files between networks and processing systems
- When identifying and resolving payment reconciliation exceptions
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Reconcile ACH batches between origination, Fed/EPN, and posting systems
- Match SWIFT payment messages with core banking debit/credit entries
- Reconcile card settlement files from Visa/Mastercard with acquirer/issuer records
- Identify reconciliation breaks and classify by type: timing, amount, missing
- Calculate suspense account balances and track aging of unreconciled items
- Automate reconciliation matching using configurable rules and tolerances
- Generate exception reports with root cause analysis and resolution guidance
- Produce daily, weekly, and monthly reconciliation completion dashboards

## Procedure

1. Extract payment data from origination, clearing, and settlement systems
2. Apply automated matching rules: reference number, amount, date, counterparty
3. Identify unmatched transactions and classify break type
4. Investigate timing differences and expected settlement lag
5. Research amount discrepancies checking for partial payments and adjustments
6. Escalate unresolved breaks exceeding aging or dollar thresholds
7. Post reconciliation adjustments with appropriate journal entries
8. Generate reconciliation completion report with match rates and exceptions
9. Archive reconciliation evidence for internal and external audit

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
| **NACHA Operating Rules** | ACH payment processing and settlement requirements |
| **Fedwire Operating Circular 6** | Federal Reserve wire transfer service rules |
| **ISO 8583/20022** | Payment message standards for matching and reconciliation |
| **ASC 606** | Revenue recognition for payment processing fees |

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

- **Companion Agent**: `@payment-reconciliation` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |