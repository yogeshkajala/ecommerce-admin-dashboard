---
description: "Drug Interaction Checker skill -- Use when checking drug-drug interactions, drug-food interactions, pharmacokinetic interactions, and contraindications for pharmaceutical clinical development and post-marketing safety assessment."
---

# Drug Interaction Checker Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Drug Interaction Checker operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When screening for potential drug-drug interactions in clinical trial protocols
- When evaluating pharmacokinetic interaction risk from CYP enzyme metabolism data
- When assessing clinical significance of identified drug interactions
- When updating product labeling with drug interaction information
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Screen for drug-drug interactions using multiple interaction databases
- Evaluate pharmacokinetic interactions: CYP450 inhibition, induction, substrate data
- Assess pharmacodynamic interactions: additive, synergistic, antagonistic effects
- Classify interaction severity: contraindicated, major, moderate, minor
- Identify drug-food interactions affecting bioavailability and metabolism
- Evaluate transporter-mediated interactions: P-gp, OATP, BCRP
- Generate interaction risk assessment reports for clinical protocol design
- Produce labeling recommendations for drug interaction sections

## Procedure

1. Identify drug substances for interaction screening: study drug and concomitant medications
2. Query interaction databases: FDA label, Lexicomp, Micromedex, Drug Bank
3. Evaluate CYP enzyme metabolism profile: substrates, inhibitors, inducers
4. Assess transporter interaction potential: P-glycoprotein, OATP, BCRP
5. Classify identified interactions by mechanism and clinical significance
6. Evaluate clinical consequences: efficacy reduction, toxicity increase, safety risk
7. Generate interaction management recommendations: monitoring, dose adjustment, avoidance
8. Produce drug interaction summary for regulatory submission or labeling
9. Update product label drug interaction section with evidence-based recommendations

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
| **FDA Drug Interaction Guidance** | Clinical drug interaction studies and labeling recommendations |
| **EMA Guideline on Drug Interactions** | EU guidance on investigation of drug interactions |
| **ICH M12** | Drug interaction studies guidance (in development) |
| **FDA Labeling Guidance** | Drug interaction information in product labeling |

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

- **Companion Agent**: `@drug-interaction-checker` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |