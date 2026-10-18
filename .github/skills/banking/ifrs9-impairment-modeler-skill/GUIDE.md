# IFRS 9 Impairment Modeler Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when calculating expected credit loss (ECL) provisions under IFRS 9 including stage classification (performing, underperforming, non-performing), PD/LGD/EAD modeling, and macro-overlay adjustments.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ifrs9-impairment-modeler-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ifrs9-impairment-modeler-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ifrs9-impairment-modeler` agent from the Independent Agents catalogue.

## Key Capabilities

- Classify instruments into Stage 1 (12-month ECL), Stage 2 (lifetime ECL), Stage 3 (credit-impaired)
- Apply Significant Increase in Credit Risk (SICR) criteria for stage migration
- Calculate point-in-time PD term structures for each stage
- Estimate LGD incorporating collateral, recovery rates, and downturn adjustments

## Industry Standards Applied

- **IFRS 9**: Expected credit loss impairment model requirements
- **IFRS 7**: Financial instruments disclosure requirements for ECL
- **EBA Guidelines on IFRS 9**: European Banking Authority implementation guidance