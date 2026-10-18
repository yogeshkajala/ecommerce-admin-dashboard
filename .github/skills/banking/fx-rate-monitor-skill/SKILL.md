---
description: "FX Rate Monitor skill -- Use when monitoring foreign exchange rates for banking operations including spot and forward rate validation, FX risk exposure calculation, and compliance with FX Global Code of Conduct."
---

# FX Rate Monitor Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for FX Rate Monitor operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When monitoring real-time FX rates for customer pricing and risk management
- When validating FX mark-up and spread against policy thresholds
- When calculating FX exposure and hedging requirements
- When ensuring compliance with FX Global Code of Conduct
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Monitor real-time spot and forward FX rates from multiple market data sources
- Validate customer FX pricing against benchmark rates and markup policies
- Calculate portfolio FX exposure by currency pair, tenor, and business line
- Monitor FX limit utilization: intraday, end-of-day, settlement, and credit
- Detect rate manipulation anomalies and unusual trading patterns
- Generate FX rate feeds for core banking and pricing systems
- Calculate hedge effectiveness for FX hedging relationships
- Produce FX risk reports for treasury and risk management committees

## Procedure

1. Subscribe to real-time FX rate feeds from market data providers
2. Validate rate quality: staleness, cross-rate consistency, spread reasonableness
3. Distribute validated rates to downstream systems: core banking, pricing, risk
4. Monitor customer transaction pricing against benchmark rates
5. Calculate aggregate FX exposure by currency, product, and counterparty
6. Check exposure against approved limits and escalate breaches
7. Validate hedge effectiveness ratios for accounting treatment qualification
8. Generate daily FX risk report with exposure, P&L, and limit utilization
9. Produce monthly FX compliance report per Global Code requirements

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
| **FX Global Code of Conduct** | Principles for good practices in FX markets |
| **ISDA Definitions (2006/2021)** | FX product definitions and settlement conventions |
| **ASC 815** | Hedge accounting requirements for FX derivatives |
| **Dodd-Frank Title VII** | FX swap and forward reporting and clearing requirements |

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

- **Companion Agent**: `@fx-rate-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |