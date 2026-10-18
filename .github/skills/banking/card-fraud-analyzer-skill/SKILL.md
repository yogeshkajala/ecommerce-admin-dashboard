---
description: "Card Fraud Analyzer skill -- Use when analyzing card fraud patterns across issuing and acquiring portfolios, building fraud detection rule strategies, measuring fraud prevention effectiveness, and reporting card fraud metrics to payment networks."
---

# Card Fraud Analyzer Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Card Fraud Analyzer operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When analyzing card fraud trends across transaction types and channels
- When building and tuning fraud detection rules and ML model strategies
- When measuring fraud prevention effectiveness and false positive impact
- When reporting fraud metrics to Visa/Mastercard per network requirements
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Analyze fraud patterns by transaction type: CNP, CP, ATM, mobile wallet
- Build rule-based fraud detection strategies targeting emerging fraud vectors
- Measure fraud basis points against industry and network benchmarks
- Calculate false positive rates and customer friction impact
- Analyze account takeover and card testing attack patterns
- Generate fraud case investigation reports with loss quantification
- Report fraud metrics per Visa TC40/Mastercard SAFE data requirements
- Produce fraud strategy performance dashboard with KPIs

## Procedure

1. Extract transaction and fraud data from issuing and acquiring systems
2. Analyze fraud rates by channel, merchant category, geography, and card type
3. Identify emerging fraud patterns using time-series and clustering analysis
4. Build or tune detection rules targeting identified fraud vectors
5. Backtest rules against historical data measuring detection vs false positives
6. Deploy rules with monitoring and automatic performance tracking
7. Report fraud losses and recoveries against budget and industry benchmarks
8. File TC40 and SAFE reports to card networks per required timelines
9. Generate management report with fraud trends, strategy performance, and action items

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
| **EMV Chip Specifications** | Chip card authentication for counterfeit fraud prevention |
| **PCI DSS v4.0** | Card data security for fraud prevention |
| **Visa TC40** | Visa fraud reporting requirements for issuers |
| **Mastercard SAFE** | Mastercard System to Avoid Fraud Effectively reporting |

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

- **Companion Agent**: `@card-fraud-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |