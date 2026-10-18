---
description: "Randomization Validator skill -- Use when validating clinical trial randomization systems including IWRS/IRT validation, randomization algorithm verification, stratification balance checking, and unblinding procedure testing for clinical trial operations."
---

# Randomization Validator Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Randomization Validator operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When validating IWRS/IRT systems before clinical trial go-live
- When verifying randomization algorithm generates balanced treatment assignment
- When testing stratification factor balance across treatment arms
- When validating emergency unblinding procedures and documentation
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Validate IWRS/IRT system: randomization, drug supply management, visit scheduling
- Verify randomization algorithm: block randomization, stratified randomization, dynamic allocation
- Test treatment arm balance across stratification factors
- Validate drug assignment and supply management workflows
- Test emergency unblinding procedures with proper documentation
- Verify randomization code generation and sealing procedures
- Assess system access controls and role-based permissions
- Generate randomization system validation reports for regulatory inspection

## Procedure

1. Review randomization design: method, stratification factors, block sizes
2. Verify randomization algorithm implementation matches statistical design
3. Execute test randomizations validating balance across treatment arms
4. Test stratification factor balance at various enrollment scenarios
5. Validate drug assignment logic connecting randomization to supply management
6. Test emergency unblinding: request, approval, code break, documentation
7. Verify access controls: who can unblind, when, under what circumstances
8. Validate system behavior under error conditions: connectivity loss, data conflicts
9. Generate validation report documenting all test results and conclusions

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
| **ICH E6(R2)** | GCP requirements for randomization and blinding procedures |
| **ICH E9** | Statistical principles including randomization and stratification |
| **21 CFR Part 11** | Electronic records requirements for randomization systems |
| **FDA IWRS Guidance** | FDA expectations for interactive response technology validation |

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

- **Companion Agent**: `@randomization-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |