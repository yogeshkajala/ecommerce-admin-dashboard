# Randomization Validator Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when validating clinical trial randomization systems including IWRS/IRT validation, randomization algorithm verification, stratification balance checking, and unblinding procedure testing for clinical trial operations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [randomization-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
randomization-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@randomization-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate IWRS/IRT system: randomization, drug supply management, visit scheduling
- Verify randomization algorithm: block randomization, stratified randomization, dynamic allocation
- Test treatment arm balance across stratification factors
- Validate drug assignment and supply management workflows

## Industry Standards Applied

- **ICH E6(R2)**: GCP requirements for randomization and blinding procedures
- **ICH E9**: Statistical principles including randomization and stratification
- **21 CFR Part 11**: Electronic records requirements for randomization systems