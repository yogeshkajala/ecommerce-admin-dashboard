---
description: "Regulatory Disclosure Generator skill -- Use when generating regulatory disclosures for wealth management including Form ADV, Form CRS, proxy voting reports, client privacy notices, and regulatory filing packages for SEC and state registrations."
---

# Regulatory Disclosure Generator Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Regulatory Disclosure Generator operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When updating and filing Form ADV Part 1A and Part 2A for annual amendment
- When generating Form CRS (Client Relationship Summary) for retail investors
- When preparing proxy voting reports and policy disclosures
- When producing regulatory examination documentation packages
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Generate Form ADV Part 1A with firm, personnel, and AUM data
- Draft Form ADV Part 2A brochure with advisory business, fees, and risk disclosures
- Create Form CRS summary document for retail investor relationships
- Compile proxy voting report per SEC Rule 206(4)-6
- Generate client privacy notice per Regulation S-P requirements
- Prepare regulatory examination documentation packages
- Track regulatory filing deadlines and amendment triggers
- Produce 13F institutional holdings reports for large advisor filings

## Procedure

1. Compile firm data for regulatory disclosure: AUM, personnel, services, fees
2. Update Form ADV Part 1A through IARD system with current information
3. Draft or update Form ADV Part 2A brochure for material changes
4. Generate Form CRS comparing services, fees, conflicts, and standards of conduct
5. Compile proxy voting record for annual report filing
6. Prepare privacy notice updates for Regulation S-P compliance
7. Validate all disclosures for accuracy and completeness
8. File documents through appropriate regulatory systems (IARD, EDGAR)
9. Archive filed disclosures with distribution confirmation records

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
| **SEC Form ADV** | Investment advisor registration and disclosure requirements |
| **SEC Form CRS** | Client Relationship Summary for retail investors |
| **SEC Rule 206(4)-6** | Proxy voting policies and disclosure for investment advisors |
| **Reg S-P** | Privacy notice requirements for financial institutions |

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

- **Companion Agent**: `@regulatory-disclosure-generator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |