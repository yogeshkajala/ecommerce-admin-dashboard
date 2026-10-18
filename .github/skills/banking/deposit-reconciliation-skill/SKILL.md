---
description: "Deposit Reconciliation skill -- Use when reconciling deposit account balances across core banking, general ledger, and subsidiary systems, validating interest posting accuracy, and ensuring regulatory reserve and reporting compliance."
---

# Deposit Reconciliation Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Deposit Reconciliation operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When reconciling deposit balances between core banking and general ledger
- When validating interest accrual and posting accuracy for deposit products
- When ensuring FDIC insurance coverage reporting accuracy
- When investigating deposit account discrepancies and exceptions
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Reconcile deposit balances between core banking, GL, and data warehouse
- Validate daily interest accrual calculations against posted amounts
- Verify FDIC insurance coverage calculations for per-depositor aggregation
- Identify and classify reconciliation breaks by type and root cause
- Calculate reserve requirements per Regulation D thresholds
- Generate deposit composition reports by product type and maturity band
- Validate dormancy and escheatment processing against state unclaimed property laws
- Produce reconciliation exception reports with aging and resolution tracking

## Procedure

1. Extract deposit balances from core banking, GL, and subsidiary systems
2. Perform automated matching using account number, amount, and date criteria
3. Identify breaks and classify by category: timing, data entry, system error
4. Investigate unmatched items with root cause analysis
5. Validate interest posting calculations against expected accrual amounts
6. Verify FDIC insurance coverage aggregation for each depositor
7. Calculate reserve requirements and compare to actual reserves held
8. Generate reconciliation completion report with break summary and resolution status
9. Escalate unresolved breaks exceeding aging thresholds to management

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
| **FDIC Part 370** | Recordkeeping for timely deposit insurance determination |
| **Regulation D** | Reserve requirements for depository institutions |
| **ASC 405** | Accounting for deposit liabilities and accrued interest |
| **Uniform Unclaimed Property Act** | Dormant account identification and escheatment requirements |

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

- **Companion Agent**: `@deposit-reconciliation` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |