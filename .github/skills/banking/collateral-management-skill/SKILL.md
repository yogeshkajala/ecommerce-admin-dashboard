---
description: "Collateral Management skill -- Use when managing loan collateral including valuation monitoring, lien perfection tracking, collateral coverage ratio calculation, margin call processing, and collateral substitution workflows for secured lending."
---

# Collateral Management Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Collateral Management operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When monitoring collateral valuation and coverage ratios for secured loans
- When tracking lien perfection status and UCC filing renewals
- When processing margin calls when collateral value drops below thresholds
- When managing collateral substitution and release workflows
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Monitor collateral market values against loan-to-value covenant requirements
- Track UCC-1 filing dates, continuation statements, and amendments
- Calculate collateral coverage ratios including haircuts by asset class
- Process margin calls with notification, cure period, and liquidation workflows
- Manage collateral substitution requests with equivalence validation
- Monitor real estate collateral for flood zone changes and insurance compliance
- Generate collateral exception reports with aging and remediation tracking
- Produce collateral adequacy reports for credit risk committee

## Procedure

1. Receive collateral data from valuation feeds, appraisals, and market data
2. Apply haircuts by asset class per collateral policy guidelines
3. Calculate loan-to-value and collateral coverage ratios for each facility
4. Identify facilities breaching minimum collateral coverage thresholds
5. Generate margin call notifications with cure amount and deadline
6. Track UCC filing expiration dates and initiate continuation filings
7. Process collateral substitution with credit officer approval workflow
8. Monitor real estate collateral for flood zone and insurance changes
9. Generate collateral management dashboard and exception reports

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
| **UCC Article 9** | Secured transaction perfection and priority rules |
| **OCC Comptroller Handbook - Loan Portfolio** | Collateral valuation and monitoring guidance |
| **Basel III** | Credit risk mitigation through collateral recognition |
| **ISDA CSA** | Collateral management for derivatives under Credit Support Annex |

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

- **Companion Agent**: `@collateral-management` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |