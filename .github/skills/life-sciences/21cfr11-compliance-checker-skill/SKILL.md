---
description: "21 CFR Part 11 Compliance Checker skill -- Use when performing comprehensive 21 CFR Part 11 compliance checks for pharmaceutical and biotech computer systems including electronic records requirements, electronic signature controls, and audit trail validation."
---

# 21 CFR Part 11 Compliance Checker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for 21 CFR Part 11 Compliance Checker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When performing comprehensive Part 11 compliance assessment for GxP systems
- When validating system controls meet Part 11 closed and open system requirements
- When assessing Part 11 compliance during system selection or upgrade
- When preparing Part 11 compliance evidence for regulatory inspection
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Evaluate closed system controls: access control, audit trail, device checks
- Assess open system controls: encryption, digital signatures, additional protections
- Validate electronic signature controls per Part 11 Subpart C requirements
- Check signature manifestation, linking, and non-repudiation capabilities
- Verify system validation status meets Part 11 Section 11.10(a) requirements
- Assess authority checks ensuring only authorized individuals can sign
- Evaluate record retention: protection, retrieval, accuracy through retention period
- Generate comprehensive Part 11 compliance checklist with evidence documentation

## Procedure

1. Categorize system as closed or open per Part 11 definitions
2. Evaluate closed system controls per 11.10: validation, copies, record protection
3. Assess open system additional controls per 11.30: encryption, digital signatures
4. Validate electronic signature controls per 11.50: signature display requirements
5. Check signature/record linking per 11.70: tamper detection and non-repudiation
6. Verify signature components per 11.100: unique ID, biometric/knowledge factors
7. Assess authority checks per 11.100(a): signed statement of responsibility
8. Evaluate operational controls: SOPs, training, access management procedures
9. Generate Part 11 compliance report with evidence matrix and gap assessment

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
| **21 CFR Part 11** | Electronic records and electronic signatures regulatory requirements |
| **FDA Part 11 Guidance (2003)** | FDA scope and application guidance for Part 11 enforcement |
| **GAMP 5** | Risk-based approach for Part 11 compliant computer systems |
| **PDA TR 80** | Data integrity in pharmaceutical and biotech GMP environments |

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

- **Companion Agent**: `@21cfr11-compliance-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |