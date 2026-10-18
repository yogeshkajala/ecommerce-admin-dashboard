---
description: "Trade Settlement Validator skill -- Use when validating securities trade settlement processing including T+1 settlement compliance, DTCC/NSCC interaction, fails management, and reconciliation of trade, position, and cash records across front-to-back systems."
---

# Trade Settlement Validator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Trade Settlement Validator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When validating trade settlement processing for T+1 compliance
- When reconciling trade records across front office, middle office, and back office
- When managing settlement fails and buy-in procedures
- When verifying DTCC/NSCC clearing and settlement submissions
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Validate trade matching and confirmation across counterparties
- Monitor settlement instruction delivery to DTCC/NSCC and custodians
- Track settlement status through lifecycle: matched, affirmed, settled, failed
- Identify and escalate potential settlement fails before settlement date
- Calculate failed trade costs including buy-in exposure and penalty interest
- Reconcile trade, position, and cash records across front-to-back systems
- Generate settlement risk reports with counterparty exposure analysis
- Produce regulatory settlement compliance reports for SEC Rule 15c6-1

## Procedure

1. Receive executed trade details from front office trading systems
2. Validate trade economics: security, quantity, price, settlement date, counterparty
3. Submit settlement instructions to DTCC/NSCC or bilateral custodian
4. Monitor trade matching status and resolve discrepancies
5. Track affirmation and confirmation workflows for institutional trades
6. Identify at-risk settlements and initiate pre-fail remediation
7. Process settlement on value date with cash and security movement validation
8. Investigate and resolve any failed settlements with counterparty
9. Generate end-of-day settlement report with completion rates and fails analysis

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
| **SEC Rule 15c6-1** | T+1 standard settlement cycle for securities transactions |
| **DTCC/NSCC Rules** | Clearing and settlement procedures for US securities markets |
| **ISO 15022/20022** | Securities messaging standards for settlement instructions |
| **CSDR (EU)** | Central Securities Depositories Regulation settlement discipline |

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

- **Companion Agent**: `@trade-settlement-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |