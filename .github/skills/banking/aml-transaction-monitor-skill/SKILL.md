---
description: "AML Transaction Monitor skill -- Use when monitoring financial transactions for suspicious activity patterns, detecting potential money laundering schemes (structuring, layering, integration), generating Suspicious Activity Reports (SARs), and ensuring BSA/AML compliance."
---

# AML Transaction Monitor Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for AML Transaction Monitor operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When monitoring real-time and batch transactions for suspicious activity patterns
- When detecting structuring, smurfing, layering, and integration schemes
- When generating Suspicious Activity Reports for FinCEN filing
- When calibrating transaction monitoring rules and thresholds
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Analyze transaction patterns for structuring (breaking transactions below CTR thresholds)
- Detect rapid movement of funds indicative of layering schemes
- Identify round-trip transactions and circular fund flows
- Monitor peer-group deviations in transaction behavior
- Generate SAR narratives with supporting transaction evidence
- Calibrate monitoring rules to reduce false positive rates while maintaining detection
- Track CTR filing obligations for cash transactions exceeding ,000
- Perform lookback analysis for newly identified suspicious patterns

## Procedure

1. Ingest transaction data from core banking, payment, and wire transfer systems
2. Apply rule-based detection for known typologies (structuring, layering, integration)
3. Execute statistical anomaly detection against customer peer-group baselines
4. Score alerts by risk severity using multi-factor assessment
5. Enrich alerts with customer KYC data, account history, and relationship mapping
6. Triage alerts through automated disposition for clear false positives
7. Generate SAR narrative with chronological transaction evidence for true positives
8. Submit SAR filing package to BSA Officer for review and FinCEN submission
9. Update monitoring rules based on new typologies and regulatory guidance

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
| **BSA/AML** | Suspicious Activity Report filing requirements and thresholds |
| **FinCEN Guidelines** | SAR filing procedures, CTR requirements, and beneficial ownership |
| **FATF 40 Recommendations** | International standards for combating money laundering and terrorist financing |
| **Wolfsberg Principles** | AML guidance for correspondent banking and private banking |

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

- **Companion Agent**: `@aml-transaction-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |