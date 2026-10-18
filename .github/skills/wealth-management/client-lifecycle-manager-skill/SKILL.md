---
description: "Client Lifecycle Manager skill -- Use when managing wealth management client lifecycle events including onboarding, periodic reviews, life events (inheritance, divorce, retirement), relationship deepening, and eventual account closing or transfer."
---

# Client Lifecycle Manager Skill

**Category:** Domain Skills > Industry > Wealth Management

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Client Lifecycle Manager operations within the Wealth Management industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Wealth Management.

## When to Use

- When orchestrating new client onboarding with documentation and account setup
- When scheduling and preparing periodic client review meetings
- When managing client life event triggers that require plan updates
- When processing account transfers, terminations, and ACAT processing
- When Wealth Management industry-specific regulatory compliance must be verified
- When domain expertise in Wealth Management business processes is required

## Capabilities

- Orchestrate new client onboarding with checklist and milestone tracking
- Prepare periodic review packages with performance, allocation, and planning updates
- Trigger life event workflows: marriage, divorce, inheritance, retirement, death
- Manage household relationship mapping and beneficiary synchronization
- Process ACAT transfers-in with cost basis and lot matching validation
- Handle advisor transitions with client communication and account reassignment
- Track client engagement metrics: meeting frequency, response times, NPS scores
- Generate client lifecycle dashboard for practice management

## Procedure

1. Detect lifecycle event trigger: new client, review due, life event, transfer request
2. Assemble required documentation and data for event type
3. Execute onboarding checklist: agreements, KYC, risk profile, IPS, account opening
4. Prepare review package: performance, allocation, goals progress, tax planning
5. Process life event updates: beneficiary changes, risk profile update, plan revision
6. Handle ACAT transfer with cost basis reconciliation and lot matching
7. Manage advisor transition with client communication plan
8. Update CRM with lifecycle event completion and next actions
9. Generate lifecycle activity report for compliance and management review

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
| **SEC Marketing Rule** | Client communication and relationship management compliance |
| **FINRA Rule 4512** | Customer account information requirements and updates |
| **ACAT Rules** | Automated Customer Account Transfer procedures |
| **Reg S-P** | Privacy and data protection for client lifecycle data |

## Anti-Hallucination Rules

- Do not fabricate portfolio performance data -- use actual client records only
- Do not assume market conditions without citing specific data sources
- Do not generate investment recommendations without proper suitability analysis
- Always distinguish between regulatory requirements and industry best practices
- Do not fabricate regulatory references, statute numbers, or compliance framework citations
- Always cite the specific regulation, standard, or guideline being referenced
- If industry-specific data is unavailable, explicitly state the gap and request clarification
- Never assume jurisdiction-specific rules apply universally across regions

## Quality Checks

- Verify all regulatory references against current published versions
- Cross-check financial calculations using independent verification methods
- Validate all compliance assertions against specific regulatory text
- Ensure all recommendations include client suitability considerations
- All outputs must include confidence scores for key assertions
- Cross-reference findings against authoritative industry sources
- Flag any assumptions made during analysis with explicit markers
- Validate all numerical calculations with step-by-step workings
- Ensure all recommendations are actionable with clear ownership and timelines

## Integration Points

- **Companion Agent**: `@client-lifecycle-manager` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Wealth Management domain coverage |