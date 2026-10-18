---
description: "ESG Scoring Engine skill -- Use when calculating Environmental, Social, and Governance (ESG) scores for investment portfolios including carbon footprint analysis, social impact assessment, governance quality evaluation, and ESG integration into investment decisions."
---

# ESG Scoring Engine Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for ESG Scoring Engine operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When scoring portfolio holdings on ESG criteria using multiple data providers
- When calculating portfolio carbon footprint and climate risk exposure
- When screening investments for controversial activities and norm violations
- When integrating ESG considerations into investment selection and monitoring
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate composite ESG scores using MSCI, Sustainalytics, and ISS ESG data
- Measure portfolio carbon footprint: Scope 1, 2, and estimated Scope 3 emissions
- Apply negative screening for controversial weapons, tobacco, thermal coal, etc.
- Assess governance quality: board independence, executive compensation, shareholder rights
- Evaluate social factors: labor practices, human rights, community impact
- Generate SFDR Article 8/9 fund disclosures for EU regulatory compliance
- Produce TCFD-aligned climate risk reports for institutional portfolios
- Compare portfolio ESG scores against benchmark and peer ESG ratings

## Procedure

1. Extract portfolio holdings and map to ESG data provider identifiers
2. Retrieve ESG ratings from multiple providers (MSCI, Sustainalytics, ISS)
3. Calculate aggregate ESG scores using provider consensus methodology
4. Compute portfolio carbon footprint using enterprise value allocation method
5. Apply negative and norms-based screening filters per investment policy
6. Assess individual holding ESG controversies and controversy scores
7. Calculate portfolio-level ESG metrics against benchmark
8. Generate ESG scorecard with environmental, social, and governance breakdowns
9. Produce client ESG report with regulatory disclosures where required

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
| **SFDR (EU)** | Sustainable Finance Disclosure Regulation classification and reporting |
| **TCFD Recommendations** | Task Force on Climate-related Financial Disclosures framework |
| **UN PRI** | Principles for Responsible Investment integration guidance |
| **EU Taxonomy** | EU classification system for environmentally sustainable activities |

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

- **Companion Agent**: `@esg-scoring-engine` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |