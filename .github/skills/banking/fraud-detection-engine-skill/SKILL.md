---
description: "Fraud Detection Engine skill -- Use when detecting fraudulent transactions across payment channels (card, ACH, wire, P2P), analyzing fraud patterns using behavioral analytics, and managing fraud case workflows from detection through resolution."
---

# Fraud Detection Engine Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Fraud Detection Engine operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When detecting fraudulent card transactions in real-time authorization flow
- When analyzing ACH and wire transfer fraud patterns
- When investigating account takeover and synthetic identity fraud
- When calibrating fraud detection models and rule thresholds
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Score transactions in real-time using ML-based fraud models and rule engines
- Detect card-not-present fraud using device fingerprinting and behavioral biometrics
- Identify account takeover patterns through login anomaly and session analysis
- Analyze ACH fraud including unauthorized debits and business email compromise
- Detect synthetic identity fraud through cross-reference of identity attributes
- Generate fraud case files with evidence timeline and loss calculation
- Track fraud rates by channel, product, and geography against industry benchmarks
- Produce regulatory fraud reporting for Reg E and Reg Z compliance

## Procedure

1. Receive transaction authorization request with customer and device context
2. Execute real-time scoring using ensemble fraud model (rules + ML)
3. Apply velocity checks, geo-location analysis, and device reputation scoring
4. Route high-risk scores to real-time decline or step-up authentication
5. Generate fraud alert with risk factors and recommended action
6. Enrich case with historical customer behavior and cross-channel activity
7. Calculate actual and prevented fraud losses for reporting
8. Update fraud models with confirmed fraud and false positive feedback
9. Generate regulatory compliance reports (Reg E timelines, provisional credit)

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
| **PCI DSS** | Payment card data security standards for fraud prevention |
| **EMV 3DS** | 3-D Secure protocol for card-not-present authentication |
| **Regulation E** | Electronic fund transfer error resolution and liability rules |
| **Regulation Z** | Credit card billing error resolution and unauthorized use limits |

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

- **Companion Agent**: `@fraud-detection-engine` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |