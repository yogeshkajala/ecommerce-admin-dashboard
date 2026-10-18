---
description: "Core Banking Migration skill -- Use when planning and executing core banking system migrations including account data migration, transaction history preservation, integration rewiring, and parallel run validation between legacy and target platforms."
---

# Core Banking Migration Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Core Banking Migration operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When planning migration from legacy core banking to modern platforms
- When executing account and transaction data migration with validation
- When managing parallel run between legacy and target core banking systems
- When rewiring integrations and interfaces during core banking transformation
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Map legacy core banking data models to target platform schema
- Design incremental migration waves by product, branch, and customer segment
- Execute parallel transaction processing with real-time comparison
- Validate account balance reconciliation between legacy and target systems
- Manage integration rewiring for channels, payment systems, and GL interfaces
- Test end-of-day batch processing including interest calculation and posting
- Verify regulatory reporting continuity during and after migration
- Coordinate branch operations cutover with minimal customer disruption

## Procedure

1. Discover and document legacy core banking data model and integration landscape
2. Design target-state data model mapping with transformation rules
3. Plan migration waves prioritizing by risk, volume, and business criticality
4. Execute pilot migration wave with subset of accounts and full validation
5. Run parallel processing comparing transaction outcomes between systems
6. Validate account balance reconciliation with zero-tolerance variance
7. Execute integration cutover for each channel and downstream system
8. Perform end-of-day processing validation including GL posting and reporting
9. Decommission legacy system components after stability period confirmation

## Output Format

Return structured results:

- **Executive Summary: key findings, risk level, compliance status, recommended actions**
- **Detailed Analysis: line-by-line assessment results with evidence references**
- **Regulatory Mapping: applicable regulations, specific sections, compliance status**
- **Compliance Status**: applicable regulatory frameworks, control status, evidence references
- **Risk Assessment**: identified risks with likelihood, impact, and mitigation recommendations
- **Action Items**: prioritized remediation actions with ownership, timeline, and success criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **ISO 20022** | Universal financial messaging standard for payment and reporting |
| **BIAN (Banking Industry Architecture Network)** | Service-oriented banking architecture reference model |
| **Basel III** | Operational risk considerations during system migration |
| **OCC Bulletin 2013-29** | Third-party risk management for vendor platform migrations |

## Anti-Hallucination Rules

- Do not fabricate regulatory citations -- verify all statute and regulation references
- Do not assume institution-specific policies without explicit documentation
- Do not generate synthetic financial data without clearly marking it as illustrative
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include implementation feasibility assessment
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@core-banking-migration-skill` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |