---
description: "Customer Onboarding Orchestrator skill -- Use when orchestrating end-to-end banking customer onboarding workflows including digital account opening, identity verification, KYC/CDD, product bundling, and regulatory disclosure delivery."
---

# Customer Onboarding Orchestrator Skill

**Category:** Domain Skills > Industry > Banking

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Customer Onboarding Orchestrator operations within the Banking industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Banking.

## When to Use

- When managing digital account opening workflows for retail and small business
- When orchestrating identity verification and document capture processes
- When ensuring regulatory disclosure delivery during account opening
- When managing product bundling and cross-sell during onboarding
- When Banking industry-specific regulatory compliance must be verified
- When domain expertise in Banking business processes is required

## Capabilities

- Orchestrate multi-step digital account opening with form prefill and save/resume
- Manage identity verification through document capture, liveness check, and bureau verification
- Integrate KYC/CDD screening including sanctions, PEP, and adverse media checks
- Deliver required regulatory disclosures: privacy notice, account agreement, fee schedule
- Enable product bundling: checking + savings + debit card + online banking
- Process funding source validation: ACH, wire, branch deposit, card funding
- Generate account activation communications and welcome packages
- Track onboarding funnel metrics: start, abandon, complete, time-to-open

## Procedure

1. Capture applicant information: personal details, address, SSN, employment
2. Execute identity verification: document scan + liveness + bureau attributes
3. Perform KYC screening: sanctions, PEP, adverse media, risk scoring
4. Deliver regulatory disclosures and capture electronic consent
5. Present product recommendations and process bundled product selection
6. Validate funding source and process initial deposit
7. Activate accounts and issue credentials: debit card, online/mobile banking
8. Send welcome communications with account details and getting-started guide
9. Track onboarding completion and initiate relationship deepening workflow

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
| **BSA/AML CIP** | Customer Identification Program requirements for account opening |
| **ESIGN Act** | Electronic signature and consent requirements for digital onboarding |
| **Reg DD (TISA)** | Account disclosure requirements at opening |
| **Reg E** | Electronic fund transfer disclosure requirements for debit cards |

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

- **Companion Agent**: `@customer-onboarding-orchestrator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Banking domain coverage |