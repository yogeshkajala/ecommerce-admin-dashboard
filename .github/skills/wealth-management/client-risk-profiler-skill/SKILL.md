---
description: "Client Risk Profiler skill -- Use when assessing client risk tolerance and capacity including psychometric risk assessment, risk capacity analysis based on financial situation, and investment policy statement generation for wealth management relationships."
---

# Client Risk Profiler Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Client Risk Profiler operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When conducting risk tolerance assessment for new wealth management clients
- When updating risk profiles for existing clients during periodic reviews
- When resolving discrepancies between stated risk tolerance and portfolio positioning
- When generating investment policy statements reflecting client risk parameters
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Administer psychometric risk tolerance questionnaires with score calculation
- Assess risk capacity based on income stability, net worth, time horizon, and liquidity needs
- Identify discrepancies between risk tolerance, capacity, and current portfolio risk level
- Map risk scores to model portfolio recommendations by risk band
- Generate Investment Policy Statements (IPS) documenting client risk parameters
- Track risk profile changes over time for suitability documentation
- Handle multi-goal risk profiling for clients with varied time horizons
- Produce risk assessment documentation for compliance and audit review

## Procedure

1. Administer risk tolerance questionnaire capturing behavioral risk preferences
2. Score questionnaire responses using validated psychometric methodology
3. Assess risk capacity analyzing income, expenses, assets, liabilities, and time horizon
4. Determine composite risk classification combining tolerance and capacity scores
5. Identify any discrepancy between risk profile and current portfolio positioning
6. Map risk classification to appropriate model portfolio or allocation band
7. Draft Investment Policy Statement with risk parameters and constraints
8. Review IPS with client and obtain acknowledgment signature
9. Archive risk assessment and IPS for compliance recordkeeping

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
| **CFA Institute IPS Guidance** | Investment Policy Statement best practices and components |
| **Reg BI Care Obligation** | Understanding client risk profile for best interest standard |
| **FINRA Rule 2111** | Suitability requiring reasonable basis for risk assessment |
| **MiFID II Suitability** | Client risk profiling requirements for investment services |

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

- **Companion Agent**: `@client-risk-profiler` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |