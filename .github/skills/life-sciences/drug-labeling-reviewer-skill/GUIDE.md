# Drug Labeling Reviewer Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when reviewing pharmaceutical product labeling including USPI (US Prescribing Information), SmPC (Summary of Product Characteristics), patient labeling, and promotional material review for regulatory compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [drug-labeling-reviewer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
drug-labeling-reviewer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@drug-labeling-reviewer` agent from the Independent Agents catalogue.

## Key Capabilities

- Review USPI structure per PLR (Physician Labeling Rule) format requirements
- Validate labeling claims against clinical trial data and approved indications
- Assess SmPC compliance with EU QRD template and regulatory guidance
- Review Medication Guide and PPI for patient comprehension and accuracy

## Industry Standards Applied

- **21 CFR 201**: FDA labeling requirements for human prescription drugs
- **FDA PLR (Physician Labeling Rule)**: Format and content requirements for prescription drug labeling
- **EU QRD Template**: EU quality review of documents template for SmPC and PIL