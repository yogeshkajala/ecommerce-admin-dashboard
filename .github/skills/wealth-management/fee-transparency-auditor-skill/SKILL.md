---
description: "Fee Transparency Auditor skill -- Use when auditing advisory fee structures for transparency, reasonableness, and compliance with disclosure requirements including fee-on-fee analysis, breakpoint validation, and hidden cost identification."
---

# Fee Transparency Auditor Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Fee Transparency Auditor operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When auditing advisory fee calculations for accuracy and client agreement compliance
- When identifying hidden costs: fund expenses, trading costs, platform fees
- When validating fee breakpoints and tiered schedule application
- When preparing fee disclosure documentation for regulatory examination
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Calculate all-in cost: advisory fee, fund expenses, trading costs, platform fees
- Validate tiered fee schedules and breakpoint application accuracy
- Identify fee-on-fee situations where advisory fees apply to fund-of-fund layers
- Compare fee levels against industry benchmarks and peer firms
- Detect fee billing errors: incorrect AUM, wrong schedule, timing errors
- Analyze revenue sharing and 12b-1 fee disclosure adequacy
- Validate fee disclosure in Form ADV Part 2A and client agreements
- Generate fee transparency report for client and compliance review

## Procedure

1. Extract fee billing data: AUM, fee schedules, deductions, and revenue sharing
2. Recalculate advisory fees applying correct tiered schedules and breakpoints
3. Identify all layers of embedded costs: fund expenses, trading, custody, platform
4. Calculate total cost of ownership as percentage of client AUM
5. Compare fees against industry surveys and peer firm databases
6. Check revenue sharing arrangements for adequate disclosure
7. Validate fee disclosure accuracy in Form ADV and client agreements
8. Generate fee audit report with findings and remediation recommendations
9. Present findings to compliance and management for corrective action

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
| **SEC Form ADV Part 2A** | Fee disclosure requirements for registered investment advisors |
| **DOL Fiduciary Rule** | Fee disclosure for retirement account advisory services |
| **FINRA Rule 2121** | Fair prices and commissions for broker-dealer transactions |
| **MiFID II Cost Disclosure** | Ex-ante and ex-post cost and charges disclosure |

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

- **Companion Agent**: `@fee-transparency-auditor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |