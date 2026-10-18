---
description: "SWIFT Message Validator skill -- Use when validating SWIFT financial messages (MT/MX), ensuring compliance with SWIFT standards, verifying message formatting, and testing end-to-end payment message flows for correspondent banking operations."
---

# SWIFT Message Validator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for SWIFT Message Validator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When validating SWIFT MT and MX message formatting and content
- When testing correspondent banking payment message flows
- When migrating from SWIFT MT to ISO 20022 MX message formats
- When verifying sanctions screening integration with SWIFT message processing
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Validate SWIFT MT message structure against SWIFT Standards Release Guide
- Parse and validate ISO 20022 MX messages including pacs, camt, and pain schemas
- Test end-to-end payment message flows: MT103, MT202, MT199, MT299
- Verify sanctions screening integration points in message processing chain
- Map MT-to-MX migration for CBPR+ (Cross-Border Payments and Reporting Plus)
- Validate SWIFT gpi tracking fields and UETR uniqueness
- Test exception handling for SWIFT message repair and investigation workflows
- Generate compliance reports for SWIFT CSP (Customer Security Programme)

## Procedure

1. Parse incoming SWIFT message and validate structural integrity
2. Check mandatory fields, field formats, and allowed values per message type
3. Validate BIC codes against SWIFT BIC directory for sender and receiver
4. Execute sanctions screening on all parties (ordering, beneficiary, intermediary)
5. Verify UETR presence and format for gpi-enabled messages
6. Test message acknowledgment and rejection flows (MT012, MT019)
7. Validate nostro/vostro reconciliation entries generated from payment messages
8. Generate message validation report with pass/fail by field
9. Archive validation evidence for correspondent banking audit trail

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
| **SWIFT Standards Release Guide** | MT message format specifications and validation rules |
| **ISO 20022** | MX message schemas for payments, cash management, and securities |
| **SWIFT CSP** | Customer Security Programme mandatory and advisory controls |
| **CBPR+** | Cross-Border Payments and Reporting Plus migration guidelines |

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

- **Companion Agent**: `@swift-message-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |