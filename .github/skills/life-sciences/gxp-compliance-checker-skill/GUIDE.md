# GxP Compliance Checker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when validating GxP compliance across pharmaceutical operations including GMP for manufacturing, GLP for laboratory studies, GCP for clinical trials, GDP for distribution, and GVP for pharmacovigilance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gxp-compliance-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gxp-compliance-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gxp-compliance-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess GMP compliance against 21 CFR 210/211 and EU GMP Annex requirements
- Validate GLP study compliance per 21 CFR Part 58 and OECD GLP Principles
- Check GCP compliance against ICH E6(R2) for clinical trial documentation
- Evaluate GDP compliance for pharmaceutical storage and distribution

## Industry Standards Applied

- **21 CFR 210/211**: FDA cGMP requirements for pharmaceutical manufacturing
- **21 CFR Part 58**: FDA GLP requirements for nonclinical laboratory studies
- **ICH E6(R2)**: GCP requirements for clinical trial conduct