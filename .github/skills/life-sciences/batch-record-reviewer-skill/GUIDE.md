# Batch Record Reviewer Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when reviewing pharmaceutical manufacturing batch records including process parameter verification, in-process testing results, deviation documentation, and batch disposition decision support for GMP compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [batch-record-reviewer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
batch-record-reviewer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@batch-record-reviewer` agent from the Independent Agents catalogue.

## Key Capabilities

- Review batch record completeness and accuracy against master batch record
- Verify process parameters against validated ranges: temperature, pressure, time, pH, speed
- Validate in-process testing results against acceptance criteria
- Assess environmental monitoring data during manufacturing

## Industry Standards Applied

- **21 CFR 211**: FDA cGMP requirements for batch record review and disposition
- **EU GMP Annex 1**: Manufacture of sterile products batch record requirements
- **ICH Q7**: GMP for active pharmaceutical ingredients batch documentation