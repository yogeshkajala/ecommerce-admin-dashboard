# Loan Origination Analyzer Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when analyzing loan origination workflows for efficiency, compliance with TRID (TILA-RESPA Integrated Disclosure), HMDA reporting accuracy, and end-to-end cycle time optimization from application through funding.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [loan-origination-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
loan-origination-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@loan-origination-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Map end-to-end loan origination workflow identifying bottlenecks and rework loops
- Validate Loan Estimate and Closing Disclosure compliance with TRID timing rules
- Analyze HMDA LAR data for completeness, accuracy, and geocoding correctness
- Calculate tolerance cure amounts for changed circumstances

## Industry Standards Applied

- **TRID (TILA-RESPA)**: Integrated mortgage disclosure timing and content requirements
- **HMDA (Reg C)**: Home Mortgage Disclosure Act data collection and reporting
- **ECOA (Reg B)**: Fair lending in mortgage origination and adverse action