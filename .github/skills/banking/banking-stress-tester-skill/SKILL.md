---
description: "Banking Stress Tester skill -- Use when performing enterprise-wide stress testing for CCAR, DFAST, and internal capital adequacy assessment including macroeconomic scenario design, loss projection, and capital impact analysis."
---

# Banking Stress Tester Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Banking Stress Tester operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When running CCAR and DFAST supervisory stress test scenarios
- When designing internal stress test scenarios for capital planning
- When projecting credit losses under adverse and severely adverse conditions
- When assessing capital adequacy under stress for strategic planning
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Design macroeconomic stress scenarios with multiple risk factor paths
- Project credit losses by portfolio segment using statistical and judgmental models
- Model pre-provision net revenue (PPNR) under stress conditions
- Calculate stress capital ratios: CET1, Tier 1, Total Capital, Leverage
- Assess concentration risk impact under sector and geographic stress
- Model counterparty credit risk under market stress scenarios
- Generate CCAR capital plan submission with capital actions and distributions
- Produce internal capital adequacy assessment documentation

## Procedure

1. Receive macroeconomic scenarios: baseline, adverse, severely adverse
2. Map scenario variables to portfolio risk drivers
3. Project credit losses for each portfolio: C&I, CRE, residential, consumer, cards
4. Model PPNR components under each scenario: NII, non-interest income, expense
5. Calculate provision expense and allowance under CECL methodology
6. Determine capital ratios at each quarter over projection horizon
7. Assess whether minimum capital ratios are maintained throughout stress period
8. Generate comprehensive stress test report with executive summary
9. Submit regulatory stress test results per CCAR/DFAST timeline requirements

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
| **CCAR** | Comprehensive Capital Analysis and Review framework and timeline |
| **DFAST** | Dodd-Frank Act Stress Testing requirements and scenarios |
| **SR 15-18** | Federal Reserve capital planning and positions guidance |
| **CECL (ASC 326)** | Expected credit loss provisioning under stress scenarios |

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

- **Companion Agent**: `@banking-stress-tester` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |