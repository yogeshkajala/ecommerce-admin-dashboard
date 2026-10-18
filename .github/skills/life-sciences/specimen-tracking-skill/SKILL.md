---
description: "Specimen Tracking skill -- Use when tracking biological specimens in clinical trials including sample collection, storage, shipment, chain of custody, biobank management, and regulatory compliance for clinical trial biospecimen management."
---

# Specimen Tracking Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Specimen Tracking operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When tracking biological specimen collection and processing at clinical sites
- When managing specimen shipment and chain of custody documentation
- When maintaining biobank inventory with storage condition monitoring
- When ensuring regulatory compliance for specimen handling and retention
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Track specimen lifecycle: collection, processing, storage, shipment, analysis, disposal
- Manage chain of custody documentation from collection through final analysis
- Monitor specimen storage conditions: temperature, access events, inventory audits
- Coordinate specimen shipments with courier, customs, and receiving lab
- Manage biobank inventory with specimen type, volume, and availability tracking
- Validate specimen handling against protocol-specified requirements
- Track specimen consent: broad consent, specific consent, withdrawal handling
- Generate specimen tracking reports for study management and regulatory inspection

## Procedure

1. Configure specimen collection schedule per protocol visit and procedure matrix
2. Track specimen collection at site: subject, timepoint, specimen type, volume
3. Validate collection against protocol requirements: timing, processing, storage conditions
4. Package specimens for shipment per IATA DGR regulations and kit instructions
5. Track shipment: courier, tracking number, temperature monitoring, receipt confirmation
6. Log specimen receipt at central/specialty laboratory with condition assessment
7. Manage biobank inventory with location, storage condition, and availability
8. Process specimen requests for analysis with proper authorization
9. Generate specimen inventory and compliance report

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
| **ICH E6(R2)** | GCP requirements for specimen collection and handling in clinical trials |
| **IATA DGR** | Dangerous Goods Regulations for biological specimen shipment |
| **CAP Biorepository Accreditation** | College of American Pathologists biobank quality standards |
| **ISBER Best Practices** | International Society for Biological and Environmental Repositories standards |

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

- **Companion Agent**: `@specimen-tracking` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |