---
description: "Wire Transfer Validator skill -- Use when validating domestic and international wire transfer processing including Fedwire and CHIPS compliance, OFAC screening, travel rule compliance, and wire transfer reconciliation."
---

# Wire Transfer Validator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Wire Transfer Validator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When validating wire transfer processing for Fedwire and CHIPS compliance
- When ensuring OFAC screening coverage for all wire transfer parties
- When verifying Travel Rule (BSA) compliance for wire transfers over ,000
- When reconciling wire transfer settlements against nostro/vostro accounts
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Validate wire transfer instructions for completeness and formatting
- Screen all wire parties against OFAC sanctions lists before processing
- Verify Travel Rule compliance: originator and beneficiary information for transfers >=,000
- Monitor Fedwire and CHIPS processing windows and cutoff compliance
- Validate correspondent bank routing and intermediary BIC accuracy
- Track wire transfer SLA performance: initiation to completion time
- Identify and investigate rejected wires and OFAC interdiction holds
- Generate wire transfer compliance and operations reports

## Procedure

1. Receive wire transfer request via online banking, branch, or SWIFT message
2. Validate instruction completeness: originator, beneficiary, amount, purpose
3. Execute OFAC screening on all parties: originator, beneficiary, banks
4. Verify Travel Rule information completeness for transfers >= ,000
5. Route wire through appropriate network: Fedwire, CHIPS, or SWIFT
6. Monitor processing status through settlement confirmation
7. Reconcile settled wires against nostro/vostro account entries
8. Track rejected wires and manage repair or return processes
9. Generate daily wire transfer operations report with volumes and exceptions

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
| **Fedwire Operating Circular 6** | Federal Reserve wire transfer service procedures |
| **CHIPS Rules** | Clearing House Interbank Payments System operating rules |
| **BSA Travel Rule** | Recordkeeping and information requirements for wire transfers |
| **OFAC Regulations** | Sanctions screening requirements for wire transfer processing |

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

- **Companion Agent**: `@wire-transfer-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |