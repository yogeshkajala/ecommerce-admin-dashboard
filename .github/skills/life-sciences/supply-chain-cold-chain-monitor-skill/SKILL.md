---
description: "Supply Chain Cold Chain Monitor skill -- Use when monitoring pharmaceutical cold chain integrity including temperature monitoring, excursion detection, cold chain qualification, and GDP compliance for temperature-sensitive pharmaceutical distribution."
---

# Supply Chain Cold Chain Monitor Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Supply Chain Cold Chain Monitor operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When monitoring temperature during pharmaceutical storage and transportation
- When detecting and assessing temperature excursions against product specifications
- When qualifying cold chain shipping lanes and packaging configurations
- When ensuring GDP compliance for temperature-sensitive product distribution
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Monitor real-time temperature data from IoT sensors across supply chain
- Detect temperature excursions and assess against product stability specifications
- Calculate mean kinetic temperature (MKT) for excursion impact assessment
- Qualify shipping lanes with temperature mapping and seasonal validation
- Monitor cold storage facility conditions: temperature, humidity, door events
- Track and document cold chain breaks from manufacturing through last mile
- Validate thermal packaging performance against qualification protocols
- Generate cold chain compliance reports for regulatory inspection and quality review

## Procedure

1. Configure temperature monitoring at all cold chain nodes: storage, transport, distribution
2. Collect real-time temperature data from IoT sensors and data loggers
3. Monitor against product-specific temperature ranges (2-8C, -20C, -70C, etc.)
4. Detect excursions and assess severity: duration, magnitude, MKT calculation
5. Evaluate excursion impact using stability data and product specifications
6. Determine product disposition: acceptable, restricted use, or reject
7. Document excursion investigation and disposition decision
8. Generate cold chain performance report with compliance metrics
9. Validate shipping lane qualification for seasonal and route changes

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
| **EU GDP Guidelines (2013/C 343/01)** | Good Distribution Practice for temperature-sensitive pharmaceuticals |
| **WHO TRS 961 Annex 9** | WHO model guidance for storage and transport of pharmaceuticals |
| **USP <1079>** | Good storage and distribution practices for drug products |
| **21 CFR 211.142** | FDA warehousing and distribution temperature requirements |

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

- **Companion Agent**: `@supply-chain-cold-chain-monitor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |