# Credit Scoring Model Validator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when performing independent model validation for credit scoring models per SR 11-7 guidance, assessing model conceptual soundness, testing discriminatory power, and evaluating ongoing model performance monitoring.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [credit-scoring-model-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
credit-scoring-model-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@credit-scoring-model-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess model conceptual soundness: theory, methodology, and assumptions
- Test discriminatory power using Gini coefficient, KS statistic, and AUC-ROC
- Evaluate calibration accuracy: predicted vs observed default rates by segment
- Perform Population Stability Index analysis for input and output distributions

## Industry Standards Applied

- **SR 11-7 / OCC 2011-12**: Federal Reserve/OCC model risk management guidance
- **ECOA (Reg B)**: Fair lending model testing requirements
- **Basel III IRB**: Model requirements for internal ratings-based capital calculations