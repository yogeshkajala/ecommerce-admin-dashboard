# Drug Interaction Checker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when checking drug-drug interactions, drug-food interactions, pharmacokinetic interactions, and contraindications for pharmaceutical clinical development and post-marketing safety assessment.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [drug-interaction-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
drug-interaction-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@drug-interaction-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Screen for drug-drug interactions using multiple interaction databases
- Evaluate pharmacokinetic interactions: CYP450 inhibition, induction, substrate data
- Assess pharmacodynamic interactions: additive, synergistic, antagonistic effects
- Classify interaction severity: contraindicated, major, moderate, minor

## Industry Standards Applied

- **FDA Drug Interaction Guidance**: Clinical drug interaction studies and labeling recommendations
- **EMA Guideline on Drug Interactions**: EU guidance on investigation of drug interactions
- **ICH M12**: Drug interaction studies guidance (in development)