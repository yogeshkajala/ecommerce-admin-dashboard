# Bioequivalence Calculator Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when calculating bioequivalence parameters for generic drug development including pharmacokinetic parameter calculation, statistical analysis per FDA guidance, and bioequivalence study report generation for ANDA submissions.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [bioequivalence-calculator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
bioequivalence-calculator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@bioequivalence-calculator` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate pharmacokinetic parameters using non-compartmental analysis
- Perform bioequivalence statistical analysis: ANOVA, 90% confidence intervals
- Evaluate bioequivalence using 80-125% acceptance criteria for log-transformed data
- Design BE studies: sample size, crossover periods, washout, fed/fasted conditions

## Industry Standards Applied

- **FDA BE Guidance**: FDA guidance on bioavailability and bioequivalence studies for ANDAs
- **EMA BE Guideline**: EU guideline on investigation of bioequivalence
- **ICH M13**: Bioequivalence for immediate-release solid oral dosage forms