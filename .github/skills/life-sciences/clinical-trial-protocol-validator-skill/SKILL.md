---
description: "Clinical Trial Protocol Validator skill -- Use when validating clinical trial protocol design including endpoint selection, statistical analysis plan adequacy, ICH E6(R2) GCP compliance, inclusion/exclusion criteria assessment, and protocol amendment impact analysis."
---

# Clinical Trial Protocol Validator Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Clinical Trial Protocol Validator operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When validating clinical trial protocol design before regulatory submission
- When assessing statistical analysis plan adequacy and power calculations
- When checking ICH E6(R2) GCP compliance in protocol documentation
- When evaluating protocol amendment impact on trial integrity and timeline
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Validate protocol structure against ICH E6(R2) GCP requirements
- Assess primary and secondary endpoint selection for clinical and regulatory relevance
- Evaluate statistical analysis plan: sample size, power, analysis populations, missing data handling
- Check inclusion/exclusion criteria for scientific rationale and operational feasibility
- Analyze protocol amendment history for pattern identification and root cause
- Validate informed consent form alignment with protocol procedures and risks
- Assess safety monitoring plan including DSMB charter adequacy
- Generate protocol review report with findings categorized by regulatory impact

## Procedure

1. Receive clinical trial protocol package with amendments and analysis plan
2. Validate protocol structure completeness against ICH E6(R2) template
3. Assess primary endpoint: clinical relevance, measurement validity, regulatory acceptability
4. Evaluate statistical design: randomization, blinding, sample size justification
5. Review inclusion/exclusion criteria for scientific and operational appropriateness
6. Check safety monitoring plan: AE/SAE definitions, stopping rules, DSMB procedures
7. Validate informed consent form covers all protocol procedures and risks
8. Assess protocol feasibility: visit schedule burden, procedures complexity
9. Generate protocol review report with regulatory risk classification of findings

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
| **ICH E6(R2)** | Good Clinical Practice guidelines for clinical trial conduct |
| **ICH E8(R1)** | General considerations for clinical studies design framework |
| **ICH E9(R1)** | Statistical principles for clinical trials including estimands |
| **21 CFR Part 312** | FDA IND regulations for clinical trial requirements |

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

- **Companion Agent**: `@clinical-trial-protocol-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |