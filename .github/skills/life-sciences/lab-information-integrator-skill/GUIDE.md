# Lab Information Integrator Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when integrating laboratory information management systems (LIMS) with clinical trial and manufacturing systems including data standardization, electronic data transfer, validation, and 21 CFR Part 11 compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [lab-information-integrator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
lab-information-integrator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@lab-information-integrator` agent from the Independent Agents catalogue.

## Key Capabilities

- Integrate LIMS data with EDC using CDISC LAB data standards
- Standardize laboratory reference ranges and units across central and local labs
- Validate electronic data transfer accuracy with reconciliation checks
- Implement 21 CFR Part 11 controls: electronic signatures, audit trails, access control

## Industry Standards Applied

- **CDISC LAB**: Clinical Data Interchange Standards Consortium laboratory data model
- **21 CFR Part 11**: Electronic records and signatures for laboratory data
- **CLSI AUTO-10**: Clinical laboratory standards for system integration and data exchange