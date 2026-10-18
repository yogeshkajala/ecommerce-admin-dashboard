# Capital Adequacy Calculator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when calculating regulatory capital adequacy ratios, risk-weighted assets, capital buffers, and G-SIB surcharges for compliance with Basel III/IV and US capital framework requirements.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [capital-adequacy-calculator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
capital-adequacy-calculator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@capital-adequacy-calculator` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate CET1 capital with all regulatory adjustments (goodwill, DTA, MSR)
- Compute credit risk RWA under Standardized and Advanced approaches
- Calculate market risk capital using FRTB standardized or internal models
- Determine operational risk capital under Standardized Measurement Approach

## Industry Standards Applied

- **Basel III/IV**: International capital adequacy framework and output floor
- **Federal Reserve Reg Q**: US implementation of Basel III capital requirements
- **FDIC Part 324**: FDIC capital adequacy regulations for insured institutions