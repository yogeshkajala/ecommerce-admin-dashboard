---
description: "Pharma Supply Chain Tracker skill -- Use when tracking pharmaceutical supply chain operations including DSCSA serialization compliance, supply chain visibility, counterfeit detection, and end-to-end traceability for drug product distribution."
---

# Pharma Supply Chain Tracker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Pharma Supply Chain Tracker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When implementing DSCSA serialization and track-and-trace requirements
- When monitoring supply chain visibility from manufacturing through dispensing
- When detecting potential counterfeit products through serialization verification
- When managing product recalls with serialized traceability data
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Track serialized product through supply chain: manufacturer to dispenser
- Verify product authenticity using serialization data at each supply chain node
- Manage DSCSA transaction information (TI), transaction history (TH), and transaction statement (TS)
- Detect suspect and illegitimate products through verification processes
- Support product recall with serialized traceability for affected lots
- Monitor supply chain events: shipping, receiving, verification, returns
- Generate DSCSA compliance reports for FDA and trading partner audits
- Produce supply chain analytics dashboards with visibility and exception metrics

## Procedure

1. Assign unique product identifiers per DSCSA serialization requirements
2. Generate transaction information at each ownership change in supply chain
3. Verify product identifiers at receiving using EPCIS-compliant systems
4. Process verification requests from downstream trading partners
5. Detect serialization anomalies: duplicates, invalid identifiers, suspect products
6. Investigate suspect products per DSCSA verification procedures
7. Support recall execution with serialized lot traceability
8. Generate DSCSA compliance documentation for trading partners
9. Produce supply chain visibility reports with exception tracking

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
| **DSCSA (Drug Supply Chain Security Act)** | US pharmaceutical serialization and traceability requirements |
| **EU FMD (Falsified Medicines Directive)** | EU pharmaceutical serialization and anti-counterfeiting |
| **GS1 Standards** | Global serialization and data carrier standards for pharma |
| **EPCIS** | Electronic Product Code Information Services for supply chain events |

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

- **Companion Agent**: `@pharma-supply-chain-tracker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |