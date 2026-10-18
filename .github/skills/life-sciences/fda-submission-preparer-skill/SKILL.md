---
description: "FDA Submission Preparer skill -- Use when preparing FDA regulatory submissions including IND applications, NDA/BLA filings, CTD format compliance, eCTD technical validation, and pre-submission meeting request packages."
---

# FDA Submission Preparer Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for FDA Submission Preparer operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When assembling IND/NDA/BLA submission packages in eCTD format
- When validating CTD Module structure and content completeness
- When performing eCTD technical validation before gateway submission
- When preparing pre-IND or pre-NDA meeting request packages
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Assemble eCTD submission packages for IND, NDA, BLA, and supplements
- Validate CTD Module 1-5 structure and content completeness
- Perform eCTD technical validation against FDA gateway specifications
- Generate submission-ready PDF documents with compliant formatting and bookmarks
- Manage submission sequences: original, amendment, supplement lifecycle
- Prepare briefing documents for FDA pre-submission meetings
- Track FDA review timelines and manage information requests
- Produce submission planning timelines with critical path identification

## Procedure

1. Identify submission type and applicable FDA guidance requirements
2. Assemble CTD Module content: administrative, summaries, quality, nonclinical, clinical
3. Validate document formatting: PDF specifications, pagination, hyperlinks, bookmarks
4. Compile Module 1 regional information: forms, cover letters, patent information
5. Build eCTD backbone XML with correct lifecycle management sequences
6. Run eCTD technical validation tools checking gateway acceptance criteria
7. Review submission package for completeness against FDA checklist
8. Submit through FDA ESG (Electronic Submissions Gateway)
9. Track submission acknowledgment and manage any technical rejection resolution

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
| **ICH M4 (CTD)** | Common Technical Document organization and format requirements |
| **ICH M8 (eCTD)** | Electronic Common Technical Document specifications |
| **21 CFR Part 314** | NDA application content and format requirements |
| **FDA eCTD Technical Conformance Guide** | FDA-specific eCTD validation and submission requirements |

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

- **Companion Agent**: `@fda-submission-preparer` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |