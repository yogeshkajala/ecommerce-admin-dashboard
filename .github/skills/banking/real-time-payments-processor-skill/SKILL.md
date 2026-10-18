---
description: "Real Time Payments Processor skill -- Use when implementing and managing real-time payment processing including FedNow, RTP network, ISO 20022 message handling, instant payment fraud controls, and 24/7/365 availability requirements."
---

# Real Time Payments Processor Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Real Time Payments Processor operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When implementing FedNow or RTP network connectivity and message processing
- When validating ISO 20022 payment messages for real-time payment rails
- When building instant payment fraud detection controls
- When managing 24/7/365 payment processing availability and incident response
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Process real-time payment messages per FedNow and RTP specifications
- Validate ISO 20022 pacs.008 credit transfer messages end-to-end
- Implement real-time fraud scoring with sub-second response requirements
- Manage receive-side and send-side payment processing flows
- Handle request for payment (RFP) and request for information (RFI) messages
- Monitor system availability against 24/7/365 SLA requirements
- Implement rate limiting and velocity controls for fraud prevention
- Generate real-time payment operations reports with volume and availability metrics

## Procedure

1. Receive or initiate real-time payment request from customer channel
2. Validate payment message format per ISO 20022 and network specifications
3. Execute real-time fraud scoring within network timeout requirements
4. Apply sanctions screening with instant response capability
5. Route payment through FedNow or RTP clearing and settlement
6. Process acknowledgment and status messages through to final settlement
7. Post payment to customer account in real-time with notification
8. Monitor system health and availability on continuous basis
9. Generate payment processing reports with volumes, response times, and exceptions

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
| **FedNow Service Operating Rules** | Federal Reserve instant payment service requirements |
| **RTP Operating Rules** | The Clearing House Real-Time Payments network rules |
| **ISO 20022** | Universal financial messaging standard for instant payments |
| **FFIEC Guidance** | Faster payments risk management expectations |

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

- **Companion Agent**: `@real-time-payments-processor` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |