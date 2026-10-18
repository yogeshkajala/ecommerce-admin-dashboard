---
description: "Drug Safety Signal Detector skill -- Use when detecting drug safety signals from adverse event databases including disproportionality analysis, signal evaluation, benefit-risk assessment, and regulatory safety reporting for pharmacovigilance operations."
---

# Drug Safety Signal Detector Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Drug Safety Signal Detector operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When performing disproportionality analysis on adverse event databases
- When evaluating detected signals for clinical significance and regulatory action
- When conducting benefit-risk assessment for marketed drug products
- When preparing periodic safety update reports (PSURs) and PBRERs
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Execute disproportionality analysis: PRR, ROR, EBGM, IC using FAERS/EudraVigilance data
- Detect new safety signals from spontaneous reporting and clinical trial safety data
- Evaluate signal strength using clinical, statistical, and epidemiological criteria
- Perform cumulative case review for confirmed signals with narrative assessment
- Conduct quantitative benefit-risk assessment using structured frameworks
- Generate PSUR/PBRER safety data summaries and signal tracking tables
- Assess need for label changes, REMS modifications, or regulatory communications
- Produce signal detection and evaluation reports for safety review committees

## Procedure

1. Extract adverse event data from safety database (FAERS, EudraVigilance, company database)
2. Execute statistical signal detection: PRR, ROR, EBGM, IC against background rates
3. Apply clinical review filters to separate noise from potential true signals
4. Prioritize detected signals by severity, novelty, and public health impact
5. Perform detailed case-level review for prioritized signals
6. Evaluate signal using Bradford Hill criteria and available evidence
7. Assess benefit-risk balance with updated safety information
8. Generate signal evaluation report with recommended regulatory actions
9. Present findings to pharmacovigilance review committee for decision

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
| **ICH E2E** | Pharmacovigilance planning for drug safety signal detection |
| **FDA Guidance on Safety Reporting** | Post-marketing safety reporting requirements and signal management |
| **EU GVP Module IX** | Signal management process requirements for pharmacovigilance |
| **CIOMS Working Groups** | International guidance on benefit-risk assessment and signal detection |

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

- **Companion Agent**: `@drug-safety-signal-detector` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |