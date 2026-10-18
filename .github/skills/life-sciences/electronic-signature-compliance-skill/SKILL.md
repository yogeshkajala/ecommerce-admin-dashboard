---
description: "Electronic Signature Compliance skill -- Use when ensuring 21 CFR Part 11 compliance for electronic records and electronic signatures including system assessment, control implementation, procedural requirements, and compliance gap analysis for GxP computer systems."
---

# Electronic Signature Compliance Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Electronic Signature Compliance operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When assessing computer systems for 21 CFR Part 11 compliance
- When implementing electronic signature controls for GxP records
- When validating audit trail functionality for electronic records integrity
- When conducting compliance gap analysis for legacy and new computer systems
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Assess system architecture against 21 CFR Part 11 technical controls
- Validate electronic signature implementation: uniqueness, authority, non-repudiation
- Verify audit trail functionality: creation, modification, deletion, system events
- Evaluate access controls: user authentication, authorization, session management
- Check system configuration for electronic record integrity protection
- Assess procedural controls: SOPs, training, user agreements
- Evaluate hybrid record systems with both electronic and paper components
- Generate Part 11 compliance assessment report with gap analysis and remediation plan

## Procedure

1. Identify GxP records managed electronically within the system
2. Assess system against Part 11 technical requirements: access control, audit trail, e-signatures
3. Evaluate electronic signature implementation for each signing requirement
4. Validate audit trail completeness: who, what, when, old value, new value
5. Review access control implementation: user management, roles, authentication
6. Assess data integrity controls: backup, recovery, archive, migration
7. Evaluate procedural controls: SOPs, training, user agreements, incident management
8. Generate compliance assessment report with findings and risk classification
9. Develop remediation plan for identified gaps with implementation timeline

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
| **21 CFR Part 11** | FDA electronic records and electronic signatures requirements |
| **EU GMP Annex 11** | EU requirements for computerised systems in GMP environments |
| **FDA Part 11 Scope and Application Guidance** | FDA enforcement discretion for Part 11 requirements |
| **PIC/S PI 011-3** | PIC/S guidance on computerised systems in GxP environments |

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

- **Companion Agent**: `@electronic-signature-compliance` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |