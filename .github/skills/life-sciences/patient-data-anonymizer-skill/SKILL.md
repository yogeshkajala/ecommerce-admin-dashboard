---
description: "Patient Data Anonymizer skill -- Use when anonymizing or pseudonymizing patient data for clinical research, real-world evidence generation, data sharing, and regulatory submission ensuring HIPAA Safe Harbor/Expert Determination and GDPR compliance."
---

# Patient Data Anonymizer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Patient Data Anonymizer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When anonymizing patient data for clinical research data sharing
- When implementing HIPAA Safe Harbor de-identification for dataset release
- When performing expert determination assessment for statistical de-identification
- When pseudonymizing clinical trial data for regulatory submission redaction
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Apply HIPAA Safe Harbor method removing all 18 identifiers from datasets
- Perform statistical de-identification assessment per Expert Determination method
- Implement pseudonymization with reversible coding for authorized re-identification
- Apply k-anonymity, l-diversity, and t-closeness privacy models
- Detect and remediate re-identification risks in anonymized datasets
- Generate de-identification certificates documenting methods and residual risk
- Handle structured data (databases) and unstructured data (clinical narratives)
- Produce data anonymization reports for IRB, ethics committee, and regulatory review

## Procedure

1. Receive patient dataset with data use purpose and sharing context
2. Identify all direct and quasi-identifiers in the dataset
3. Select de-identification method: Safe Harbor or Expert Determination
4. Apply identifier removal/generalization per selected method
5. For Expert Determination: assess re-identification risk statistically
6. Apply additional privacy-preserving transformations if risk exceeds threshold
7. Validate de-identified dataset for analytical utility preservation
8. Generate de-identification documentation with methods, assumptions, residual risk
9. Certify dataset for release per applicable privacy regulation requirements

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
| **HIPAA Privacy Rule (45 CFR 164.514)** | Safe Harbor and Expert Determination de-identification methods |
| **GDPR Article 4(5), 26** | Pseudonymization and anonymization under EU data protection |
| **ICH E6(R2)** | Clinical trial data protection and confidentiality requirements |
| **21 CFR Part 11** | Electronic records security including patient data protection |

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

- **Companion Agent**: `@patient-data-anonymizer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |