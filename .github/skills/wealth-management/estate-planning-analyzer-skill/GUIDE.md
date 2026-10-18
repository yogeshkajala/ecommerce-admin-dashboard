# Estate Planning Analyzer Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when analyzing estate plans for high-net-worth clients including estate tax calculation, trust structure evaluation, beneficiary designation review, and wealth transfer strategy optimization.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [estate-planning-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
estate-planning-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@estate-planning-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate gross estate, allowable deductions, and taxable estate value
- Model estate tax under current exemption (.61M/2024) and projected sunset scenarios
- Evaluate trust structure suitability: GRAT, ILIT, QPRT, SLAT, CRT, CLT
- Review and validate beneficiary designations across all accounts and policies

## Industry Standards Applied

- **IRC Chapter 11**: Federal estate tax computation and exemptions
- **IRC Chapter 12**: Gift tax rules, annual exclusion, and lifetime exemption
- **IRC Chapter 13**: Generation-skipping transfer tax provisions