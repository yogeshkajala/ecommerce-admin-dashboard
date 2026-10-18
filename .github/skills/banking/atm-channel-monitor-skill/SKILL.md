---
description: "ATM Channel Monitor skill -- Use when monitoring ATM network operations including device availability, cash forecasting, transaction success rates, security event detection, and ATM fleet performance optimization."
---

# ATM Channel Monitor Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for ATM Channel Monitor operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When monitoring ATM fleet availability and transaction success rates
- When forecasting cash demand for ATM replenishment optimization
- When detecting ATM security events including skimming and jackpotting
- When analyzing ATM transaction mix for channel optimization
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Monitor real-time ATM status: online, offline, out-of-cash, error states
- Forecast cash demand by ATM using historical patterns and event calendars
- Detect anomalous withdrawal patterns indicating potential fraud or attack
- Identify skimming device indicators from transaction velocity and decline patterns
- Track ATM transaction success rates and diagnose failure root causes
- Optimize cash replenishment schedules to minimize idle cash and stockouts
- Monitor ATM software patch status and security compliance
- Generate ATM fleet performance dashboards and management reports

## Procedure

1. Collect ATM status and transaction data from terminal management system
2. Monitor real-time availability against SLA targets (typically 95-98%)
3. Analyze transaction success rates identifying hardware and network failure patterns
4. Run cash demand forecast models for next 7-14 day replenishment planning
5. Detect anomalous activity patterns flagging potential security events
6. Track software version compliance and patch deployment status
7. Calculate fleet utilization and identify underperforming or redundant terminals
8. Generate daily operations report with availability, incidents, and cash status
9. Produce monthly fleet performance report with optimization recommendations

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
| **PCI PTS** | PIN Transaction Security requirements for ATM terminals |
| **EMV Contact/Contactless** | Chip card and NFC payment acceptance standards |
| **ISO 8583** | ATM transaction message format standards |
| **ADA Compliance** | Accessibility requirements for ATM deployment |

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

- **Companion Agent**: `@atm-channel-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |