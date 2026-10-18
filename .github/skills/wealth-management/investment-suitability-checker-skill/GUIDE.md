# Investment Suitability Checker Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when validating investment recommendations against client suitability profiles per Reg BI (Best Interest), FINRA Rule 2111, and MiFID II suitability requirements including risk tolerance, time horizon, and financial situation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [investment-suitability-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
investment-suitability-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@investment-suitability-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Match investment recommendations to client risk tolerance profiles
- Validate product complexity against client experience and sophistication level
- Assess liquidity needs alignment with recommended investment time horizons
- Check concentration limits relative to client total investable assets

## Industry Standards Applied

- **Reg BI (SEC)**: Broker-dealer best interest obligation and care standard
- **FINRA Rule 2111**: Suitability requirements for broker-dealer recommendations
- **MiFID II Suitability**: EU investment suitability assessment requirements