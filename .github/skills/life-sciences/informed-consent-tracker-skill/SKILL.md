---
description: "Informed Consent Tracker skill -- Use when tracking informed consent processes including consent form version management, re-consent workflows, consent compliance monitoring, and e-consent implementation for clinical trial operations."
---

# Informed Consent Tracker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Informed Consent Tracker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When managing informed consent form versions across multi-site clinical trials
- When tracking re-consent requirements when protocol amendments affect participant risk
- When monitoring consent compliance: timeliness, completeness, version accuracy
- When implementing electronic informed consent (eConsent) solutions
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Manage ICF version control across trial sites with translation tracking
- Track consent status by subject: consented, re-consented, withdrawn
- Monitor re-consent requirements triggered by protocol amendments
- Validate consent form content against protocol procedures and IRB/EC requirements
- Implement e-consent workflows with multimedia educational content
- Track consent documentation completeness: signatures, dates, witness requirements
- Generate consent compliance reports for monitoring and audit
- Produce consent metrics dashboards for clinical operations oversight

## Procedure

1. Create consent form based on protocol with required regulatory elements
2. Route ICF through IRB/EC review and approval workflow
3. Distribute approved ICF versions to trial sites with implementation instructions
4. Track subject consent status: screening, randomization, re-consent triggers
5. Monitor protocol amendments for impact on informed consent
6. Initiate re-consent workflow when amendments affect participant risk or procedures
7. Validate consent documentation completeness at each monitoring visit
8. Generate consent compliance report with exceptions and remediation status
9. Archive consent documents per regulatory retention requirements

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
| **ICH E6(R2)** | GCP informed consent requirements for clinical trials |
| **21 CFR 50** | FDA protection of human subjects informed consent regulations |
| **45 CFR 46** | Common Rule requirements for informed consent and IRB review |
| **EU Clinical Trials Regulation** | EU Regulation 536/2014 informed consent requirements |

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

- **Companion Agent**: `@informed-consent-tracker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |