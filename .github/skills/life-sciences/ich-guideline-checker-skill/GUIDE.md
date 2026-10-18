# ICH Guideline Checker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when checking pharmaceutical development and manufacturing compliance against ICH guidelines including Q1-Q14 quality guidelines, E-series efficacy guidelines, S-series safety guidelines, and M-series multidisciplinary guidelines.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ich-guideline-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ich-guideline-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ich-guideline-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Map pharmaceutical processes to applicable ICH quality guidelines (Q1-Q14)
- Verify clinical development compliance with ICH E series guidelines
- Validate nonclinical study adequacy against ICH S series guidelines
- Check submission format against ICH M series (CTD, eCTD, MedDRA)

## Industry Standards Applied

- **ICH Q1-Q14**: Quality guidelines for stability, validation, impurities, specifications, QRM, QMS
- **ICH E1-E19**: Efficacy guidelines for clinical trial design, safety, biostatistics
- **ICH S1-S11**: Safety guidelines for carcinogenicity, genotoxicity, reproductive toxicity