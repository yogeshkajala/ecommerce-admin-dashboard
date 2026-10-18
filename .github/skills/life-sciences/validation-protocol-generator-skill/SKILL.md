---
description: "Validation Protocol Generator skill -- Use when generating validation protocols for pharmaceutical equipment, processes, and computer systems including IQ/OQ/PQ protocols, cleaning validation, process validation, and CSV (Computer System Validation) protocols."
---

# Validation Protocol Generator Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Validation Protocol Generator operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When generating IQ/OQ/PQ protocols for pharmaceutical equipment qualification
- When developing process validation protocols per FDA Process Validation Guidance
- When creating cleaning validation protocols for multi-product manufacturing equipment
- When preparing computer system validation protocols per GAMP 5 framework
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Generate IQ protocols with verification checks for installation specifications
- Create OQ protocols with functional testing under normal operating parameters
- Develop PQ protocols with performance testing under actual production conditions
- Draft cleaning validation protocols with sampling plans and acceptance criteria
- Prepare process validation Stage 1 (design), Stage 2 (PPQ), Stage 3 (CPV) protocols
- Generate CSV protocols aligned with GAMP 5 software category risk assessment
- Create protocol approval workflows with appropriate signature requirements
- Produce validation summary reports with results and conclusions

## Procedure

1. Receive validation request with system/process description and requirements
2. Determine validation strategy based on risk assessment and regulatory requirements
3. Define acceptance criteria based on specifications and regulatory standards
4. Draft protocol sections: objective, scope, prerequisites, test procedures, acceptance criteria
5. Include detailed test procedures with expected results and pass/fail criteria
6. Define sampling plans with statistical justification where applicable
7. Route protocol through review and approval workflow
8. Execute protocol and document results in real-time
9. Generate validation summary report with conclusions and recommendations

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
| **FDA Process Validation Guidance (2011)** | FDA guidance on process validation lifecycle approach |
| **EU GMP Annex 15** | Qualification and validation requirements for EU GMP compliance |
| **GAMP 5 (ISPE)** | Risk-based approach to GxP compliant computer systems |
| **ASTM E2500** | Specification, design, and verification of pharmaceutical systems |

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

- **Companion Agent**: `@validation-protocol-generator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |