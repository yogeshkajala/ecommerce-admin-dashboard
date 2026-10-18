---
description: "Genomics Pipeline Validator skill -- Use when validating genomics data analysis pipelines for clinical and research applications including NGS pipeline validation, variant calling accuracy, bioinformatics workflow qualification, and regulatory compliance for companion diagnostics."
---

# Genomics Pipeline Validator Skill

**Category:** Domain Skills > Industry > Life Sciences

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Genomics Pipeline Validator operations within the Life Sciences industry. This skill encapsulates industry-specific regulatory frameworks, domain expertise, business processes, and compliance requirements unique to Life Sciences.

## When to Use

- When validating NGS bioinformatics pipelines for clinical genomics applications
- When assessing variant calling accuracy: sensitivity, specificity, PPV, NPV
- When qualifying bioinformatics workflows for companion diagnostic development
- When ensuring CAP/CLIA compliance for clinical genomics laboratory operations
- When Life Sciences industry-specific regulatory compliance must be verified
- When domain expertise in Life Sciences business processes is required

## Capabilities

- Validate NGS pipeline components: alignment, variant calling, annotation, filtering
- Assess variant calling performance using reference materials (Genome in a Bottle)
- Evaluate pipeline reproducibility across runs, instruments, and operators
- Validate variant classification against ClinGen/ClinVar evidence frameworks
- Check pipeline compliance with CAP/CLIA laboratory standards
- Assess analytical validation parameters: LOD, accuracy, precision, reproducibility
- Evaluate bioinformatics pipeline version control and change management
- Generate pipeline validation reports for regulatory submission and laboratory accreditation

## Procedure

1. Define pipeline scope: target regions, variant types, specimen types
2. Select reference materials: Genome in a Bottle, synthetic controls, characterized samples
3. Execute validation runs with reference materials across instruments and operators
4. Calculate performance metrics: sensitivity, specificity, PPV, NPV by variant type
5. Evaluate reproducibility: within-run, between-run, between-operator precision
6. Validate variant annotation accuracy against ClinGen/ClinVar databases
7. Assess pipeline robustness with challenging samples: low quality, mixed, degraded
8. Generate validation report with performance summary and limitations
9. Establish ongoing quality monitoring procedures for validated pipeline

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
| **CAP Molecular Pathology Checklist** | College of American Pathologists laboratory accreditation requirements |
| **FDA NGS Guidance** | FDA considerations for next-generation sequencing device regulation |
| **ACMG/AMP Variant Classification** | Standards for interpretation and reporting of sequence variants |
| **ISO 15189** | Medical laboratory quality management and competence requirements |

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

- **Companion Agent**: `@genomics-pipeline-validator` from the Independent Agents catalogue
- **Input Sources**: Enterprise systems, regulatory databases, industry feeds, internal documentation
- **Output Consumers**: Compliance teams, risk committees, operations dashboards, audit systems
- **Upstream Skills**: Domain operational skills, security skills, compliance skills
- **Downstream Skills**: Reporting skills, documentation skills, governance skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Life Sciences domain coverage |