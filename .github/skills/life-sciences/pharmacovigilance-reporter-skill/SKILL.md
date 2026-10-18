---
description: "Pharmacovigilance Reporter skill -- Use when generating pharmacovigilance reports including ICSRs, PSURs/PBRERs, DSURs, risk management plans, and regulatory safety communications for drug safety monitoring compliance."
---

# Pharmacovigilance Reporter Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Pharmacovigilance Reporter operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When generating Individual Case Safety Reports (ICSRs) for regulatory submission
- When preparing Periodic Safety Update Reports or Periodic Benefit-Risk Evaluation Reports
- When compiling Development Safety Update Reports for clinical trial safety
- When updating Risk Management Plans based on new safety information
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Generate E2B(R3)-compliant ICSRs for FDA, EMA, and global regulatory submission
- Compile PSUR/PBRER with cumulative safety data, signal evaluation, and benefit-risk assessment
- Prepare DSUR summarizing clinical trial safety data for annual IND reporting
- Update Risk Management Plans with new safety specifications and risk minimization measures
- Track ICSR submission deadlines: 15-day expedited, 90-day periodic
- Validate ICSR data quality and medical coding accuracy (MedDRA)
- Generate aggregate safety reports for regulatory safety reviews
- Produce pharmacovigilance compliance metrics and submission tracking dashboards

## Procedure

1. Receive adverse event report from healthcare professional, patient, or literature
2. Assess report for seriousness, expectedness, and causality per company criteria
3. Code adverse event terms using MedDRA preferred terms and SOC classification
4. Generate E2B(R3) ICSR with all required data elements
5. Classify submission timeline: 15-day expedited or periodic reporting
6. Submit ICSR to applicable regulatory authorities within required timelines
7. Compile periodic safety data for PSUR/PBRER/DSUR at scheduled intervals
8. Update risk management plan if new safety information warrants changes
9. Track all submissions and generate compliance monitoring report

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
| **ICH E2B(R3)** | Electronic transmission of ICSRs data elements and message specification |
| **ICH E2C(R2)** | Periodic Benefit-Risk Evaluation Report requirements |
| **ICH E2F** | Development Safety Update Report requirements |
| **EU GVP Modules** | European pharmacovigilance good practice modules |

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

- **Companion Agent**: `@pharmacovigilance-reporter` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |