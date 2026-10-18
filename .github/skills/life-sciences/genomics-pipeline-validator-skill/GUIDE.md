# Genomics Pipeline Validator Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when validating genomics data analysis pipelines for clinical and research applications including NGS pipeline validation, variant calling accuracy, bioinformatics workflow qualification, and regulatory compliance for companion diagnostics.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [genomics-pipeline-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
genomics-pipeline-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@genomics-pipeline-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate NGS pipeline components: alignment, variant calling, annotation, filtering
- Assess variant calling performance using reference materials (Genome in a Bottle)
- Evaluate pipeline reproducibility across runs, instruments, and operators
- Validate variant classification against ClinGen/ClinVar evidence frameworks

## Industry Standards Applied

- **CAP Molecular Pathology Checklist**: College of American Pathologists laboratory accreditation requirements
- **FDA NGS Guidance**: FDA considerations for next-generation sequencing device regulation
- **ACMG/AMP Variant Classification**: Standards for interpretation and reporting of sequence variants