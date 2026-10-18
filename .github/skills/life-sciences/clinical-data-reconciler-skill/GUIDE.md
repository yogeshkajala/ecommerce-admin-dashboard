# Clinical Data Reconciler Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when reconciling clinical trial data across source documents, EDC systems, laboratory databases, and safety databases ensuring data integrity, audit trail compliance, and ALCOA+ principles for GCP data management.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [clinical-data-reconciler-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
clinical-data-reconciler-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@clinical-data-reconciler` agent from the Independent Agents catalogue.

## Key Capabilities

- Reconcile CRF/EDC data against source documents for accuracy verification
- Cross-reference safety data between EDC adverse event forms and safety database
- Validate laboratory data consistency between central lab, local lab, and EDC entries
- Check ALCOA+ compliance: Attributable, Legible, Contemporaneous, Original, Accurate

## Industry Standards Applied

- **ICH E6(R2)**: GCP data management and quality requirements for clinical trials
- **ALCOA+ Principles**: Data integrity framework for pharmaceutical data management
- **21 CFR Part 11**: Electronic records and electronic signatures compliance