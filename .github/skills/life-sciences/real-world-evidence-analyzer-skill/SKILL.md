---
description: "Real World Evidence Analyzer skill -- Use when analyzing real-world evidence (RWE) from electronic health records, claims databases, registries, and other real-world data sources for regulatory submissions, label expansions, and post-marketing safety studies."
---

# Real World Evidence Analyzer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Real World Evidence Analyzer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When designing real-world evidence studies using EHR and claims data
- When analyzing treatment effectiveness in real-world clinical practice
- When supporting regulatory submissions with real-world evidence data
- When evaluating drug utilization patterns from claims and prescription databases
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Design observational study protocols using RWD sources: EHR, claims, registries
- Apply causal inference methods: propensity score matching, IPTW, instrumental variables
- Analyze treatment effectiveness compared to RCT efficacy findings
- Evaluate drug utilization patterns: prescribing trends, adherence, switching
- Assess safety outcomes in broader real-world populations vs clinical trial populations
- Apply study quality frameworks: GRACE, ISPE GPP, FDA RWE framework
- Generate real-world evidence reports for regulatory submission support
- Produce publication-ready analyses with appropriate statistical methods

## Procedure

1. Define research question and target population for RWE study
2. Select appropriate real-world data sources based on availability and fitness-for-use
3. Design study protocol: cohort selection, exposure definition, outcome measurement
4. Assess data quality and fitness-for-use per FDA RWE Framework criteria
5. Apply analytical methods: matching, weighting, regression, time-series analysis
6. Conduct sensitivity analyses to test robustness of findings
7. Evaluate results against known RCT findings for external validation
8. Generate study report per regulatory expectations and publication standards
9. Submit evidence package to regulatory authority with study protocol and results

## Output Format

Return structured results:

- **Executive Summary: key findings, compliance status, risk classification, recommended actions**
- **Detailed Analysis: line-by-line assessment with regulatory reference citations**
- **Regulatory Impact: applicable regulations, specific sections, compliance gap severity**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **FDA RWE Framework (2018)** | FDA framework for evaluating real-world evidence in regulatory decisions |
| **ICH E2E** | Pharmacovigilance planning using real-world data sources |
| **ISPE Guidelines for Good Pharmacoepidemiology Practices** | Standards for pharmacoepidemiological studies using RWD |
| **STROBE/RECORD** | Reporting guidelines for observational studies using health data |

## Anti-Hallucination Rules

- Do not fabricate clinical data or study results -- use actual protocol and study records
- Do not assume regulatory requirements without verifying current published guidance
- Do not generate synthetic patient data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published FDA/EMA guidance
- Cross-check GxP compliance assertions against specific regulation sections
- Validate all clinical data references against actual study database records
- Ensure all recommendations include regulatory risk impact assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@real-world-evidence-analyzer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |