---
description: "Wealth Reporting Generator skill -- Use when generating comprehensive wealth reports for high-net-worth clients including consolidated performance, asset allocation, net worth statements, and multi-entity reporting across trusts, LLCs, and family office structures."
---

# Wealth Reporting Generator Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Wealth Reporting Generator operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When generating consolidated client wealth reports across all accounts and entities
- When producing quarterly performance reviews for advisory relationships
- When creating net worth statements with all asset classes including alternatives
- When generating family office reporting with multi-entity consolidation
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Consolidate positions across custodians, banks, alternative investments, and real assets
- Generate performance reports with TWR and IRR at account and household levels
- Produce net worth statements including held-away assets and liabilities
- Create asset allocation reports with current vs target comparison
- Generate income analysis reports: dividends, interest, distributions, realized gains
- Produce multi-entity reporting for trusts, LLCs, foundations, and family members
- Create custom reporting packages with client-specific views and metrics
- Generate regulatory-ready reports for Form ADV, GIPS, and client agreements

## Procedure

1. Aggregate portfolio data from all custodians and held-away sources
2. Reconcile positions and transactions across all data feeds
3. Calculate performance at position, account, household, and relationship levels
4. Generate asset allocation summary with current vs target and drift analysis
5. Produce income summary with year-to-date and projected annual income
6. Create net worth statement aggregating all assets and liabilities
7. Apply client-specific reporting preferences and custom groupings
8. Generate formatted report package for advisor review before distribution
9. Distribute reports through secure portal with electronic delivery confirmation

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
| **GIPS** | Performance calculation and reporting standards |
| **SEC Form ADV Part 2A** | Client reporting disclosure requirements for RIAs |
| **FINRA Rule 2231** | Customer account statement content requirements |
| **SOC 1/2** | Service organization controls for reporting platform security |

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

- **Companion Agent**: `@wealth-reporting-generator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |