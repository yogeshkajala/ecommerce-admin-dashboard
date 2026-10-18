---
description: "Investment Policy Enforcer skill -- Use when monitoring and enforcing investment policy statement (IPS) compliance including asset allocation limits, security restrictions, concentration limits, and liquidity constraints for managed portfolios."
---

# Investment Policy Enforcer Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Investment Policy Enforcer operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When monitoring portfolio compliance against investment policy statement guidelines
- When checking pre-trade compliance before order execution
- When investigating and documenting investment policy breaches
- When validating policy compliance for regulatory examination preparation
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Monitor real-time and end-of-day compliance against IPS constraints
- Perform pre-trade compliance checking before order submission
- Check asset allocation bands, sector limits, and issuer concentration
- Enforce restricted security lists: ESG screens, client restrictions, regulatory
- Monitor liquidity constraints and maximum position sizes
- Generate compliance breach notifications with severity and remediation deadline
- Track breach resolution and document corrective actions
- Produce compliance monitoring reports for regulatory and client review

## Procedure

1. Load investment policy guidelines: allocation limits, restrictions, constraints
2. Extract current portfolio positions and pending orders
3. Run compliance checks against all policy rules and constraints
4. Identify any breaches: active (current), passive (market-driven), technical
5. Classify breach severity and determine required remediation timeline
6. Generate breach notification to portfolio manager and compliance
7. Monitor remediation progress through to breach resolution
8. Document all compliance activity for audit trail
9. Generate periodic compliance monitoring report for management and regulators

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
| **CFA Institute IPS Standards** | Investment Policy Statement content and enforcement guidelines |
| **SEC Rule 38a-1** | Compliance policies and procedures for investment companies |
| **ERISA 404(a)** | Fiduciary compliance with investment policy for retirement plans |
| **UCITS (EU)** | Investment restrictions and compliance monitoring for UCITS funds |

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

- **Companion Agent**: `@investment-policy-enforcer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |