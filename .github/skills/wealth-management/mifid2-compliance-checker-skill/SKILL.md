---
description: "MiFID II Compliance Checker skill -- Use when validating MiFID II compliance for wealth management operations including suitability assessment, cost and charges disclosure, best execution, product governance, and inducement rules for EU-based advisory services."
---

# MiFID II Compliance Checker Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MiFID II Compliance Checker operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When validating MiFID II suitability assessments for EU client relationships
- When generating ex-ante and ex-post cost and charges disclosures
- When assessing best execution compliance for client order handling
- When evaluating product governance arrangements for investment product distribution
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Validate MiFID II suitability assessments: knowledge, experience, risk tolerance, financial situation
- Generate ex-ante cost and charges disclosure with cumulative impact illustration
- Produce ex-post cost and charges report with actual costs incurred
- Assess best execution policy compliance with systematic monitoring
- Evaluate product governance: target market definition and distribution strategy
- Check inducement rules compliance for payments from third parties
- Validate record-keeping requirements for telephone and electronic communications
- Generate MiFID II compliance dashboard with regulatory metrics

## Procedure

1. Review client categorization: retail, professional, eligible counterparty
2. Validate suitability assessment completeness and documentation
3. Calculate ex-ante costs: advisory fees, product costs, transaction costs, incidentals
4. Generate cost and charges disclosure with cumulative impact over holding periods
5. Monitor best execution venue selection and quality analysis
6. Review product governance target market definition against actual distribution
7. Assess inducement arrangements for compliance with quality enhancement test
8. Verify record-keeping for all relevant communications
9. Generate MiFID II compliance report for regulatory submission

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
| **MiFID II Directive 2014/65/EU** | Markets in Financial Instruments Directive requirements |
| **MiFID II Delegated Regulation** | Detailed implementing rules for MiFID II obligations |
| **ESMA Guidelines** | European Securities and Markets Authority implementation guidance |
| **FCA COBS** | UK FCA Conduct of Business Sourcebook (post-Brexit MiFID) |

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

- **Companion Agent**: `@mifid2-compliance-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |