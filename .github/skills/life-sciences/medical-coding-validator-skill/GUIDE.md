# Medical Coding Validator Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when validating medical coding in clinical trials including MedDRA adverse event coding, WHO Drug Dictionary coding for medications, procedure coding, and coding consistency across multi-site clinical studies.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [medical-coding-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
medical-coding-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@medical-coding-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate MedDRA coding: verbatim to LLT/PT mapping accuracy
- Code concomitant medications to WHO Drug Dictionary: ATC, INN classification
- Ensure coding consistency across sites, studies, and therapeutic areas
- Manage dictionary version upgrades with impact assessment

## Industry Standards Applied

- **MedDRA**: Medical Dictionary for Regulatory Activities for AE coding
- **WHO Drug Dictionary**: WHO classification for medication coding in clinical trials
- **CDISC CDASH**: Clinical Data Acquisition Standards Harmonization for coding fields