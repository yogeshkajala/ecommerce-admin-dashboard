---
description: "Custodian Reconciliation skill -- Use when reconciling portfolio positions, transactions, and cash balances between investment advisors internal records, custodian statements, and external data aggregation platforms for wealth management operations."
---

# Custodian Reconciliation Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Custodian Reconciliation operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When reconciling portfolio positions between advisor systems and custodian records
- When matching transactions between order management and custodian confirmations
- When investigating cash balance discrepancies between book and custodian records
- When validating corporate actions processing between custodian and internal systems
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Reconcile positions at security level between advisor platform and custodian
- Match trade confirmations between OMS, execution venues, and custodian records
- Identify and classify reconciliation breaks: position, cash, corporate action, trade
- Process corporate actions reconciliation: dividends, splits, mergers, tenders
- Validate cost basis records between advisor tax lot and custodian records
- Manage held-away asset reconciliation through data aggregation platforms
- Generate daily reconciliation reports with break aging and resolution status
- Produce operations dashboard with reconciliation KPIs and exception trends

## Procedure

1. Extract position and transaction data from advisor platform and custodian feeds
2. Perform automated position matching by security identifier and quantity
3. Identify position breaks and classify: known timing vs true discrepancy
4. Match trade confirmations across order management and custodian records
5. Reconcile cash balances accounting for pending settlements and accruals
6. Verify corporate action processing: record dates, pay dates, and elections
7. Investigate and resolve all reconciliation breaks within SLA
8. Generate daily reconciliation completion report with exception summary
9. Escalate unresolved breaks exceeding aging thresholds to operations management

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
| **SEC Rule 206(4)-2** | Custody rule requiring independent verification of client assets |
| **SOC 1 Type II** | Service organization controls for custody and reconciliation |
| **GIPS** | Data accuracy requirements for performance calculation inputs |
| **FINRA Rule 4311** | Carrying agreements and custodial requirements |

## Anti-Hallucination Rules

- Do not fabricate portfolio performance data -- use actual client records only
- Do not assume market conditions without citing specific data sources
- Do not generate investment recommendations without proper suitability analysis
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent verification methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include client suitability considerations
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@custodian-reconciliation` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |