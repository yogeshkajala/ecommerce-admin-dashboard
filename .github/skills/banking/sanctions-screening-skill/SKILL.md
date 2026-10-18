---
description: "Sanctions Screening skill -- Use when screening transactions, customers, and counterparties against sanctions lists (OFAC, EU, UN, HMT), managing screening rule calibration, and handling sanctions alert investigation workflows."
---

# Sanctions Screening Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Sanctions Screening operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When screening customers and counterparties against global sanctions lists
- When filtering payment messages for sanctions hits before processing
- When investigating and dispositioning sanctions screening alerts
- When calibrating screening rules to optimize detection vs false positive rates
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Screen names against OFAC SDN, Consolidated, Sectoral, and Non-SDN lists
- Match against EU consolidated financial sanctions list and UN Security Council lists
- Screen payment messages (SWIFT MT/MX) against all applicable sanctions programs
- Apply fuzzy matching algorithms with configurable thresholds for name variations
- Handle screening for alias names, transliterations, and partial matches
- Escalate true hits to compliance for blocking, rejecting, or licensing determination
- Generate OFAC 50% Rule analysis for entity ownership chains
- Produce sanctions screening audit reports and regulatory examination documentation

## Procedure

1. Receive screening request: customer onboarding, transaction, or periodic batch
2. Normalize input data: name, address, country, date of birth, identification
3. Execute primary screening against all applicable sanctions lists
4. Apply secondary matching for aliases, former names, and transliterations
5. Score match quality using multi-factor matching confidence
6. Route alerts by confidence tier: auto-clear, analyst review, escalation
7. Investigate potential matches with additional identity attributes
8. Document disposition decision with supporting evidence
9. File blocking reports for confirmed sanctions matches per OFAC requirements

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
| **OFAC Regulations** | US sanctions compliance, SDN list screening, and blocking requirements |
| **EU Restrictive Measures** | European Union financial sanctions implementation |
| **UN Security Council Resolutions** | UN targeted financial sanctions requirements |
| **HMT Financial Sanctions** | UK Her Majesty Treasury sanctions list and reporting |

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

- **Companion Agent**: `@sanctions-screening` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |