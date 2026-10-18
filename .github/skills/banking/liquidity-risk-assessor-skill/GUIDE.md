# Liquidity Risk Assessor Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when assessing bank liquidity risk including Liquidity Coverage Ratio (LCR), Net Stable Funding Ratio (NSFR), contingency funding plan adequacy, and intraday liquidity monitoring per Basel III/IV requirements.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [liquidity-risk-assessor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
liquidity-risk-assessor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@liquidity-risk-assessor` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate Liquidity Coverage Ratio with HQLA classification and stress outflows
- Compute Net Stable Funding Ratio from available and required stable funding
- Model liquidity stress scenarios: idiosyncratic, market-wide, and combined
- Assess contingency funding plan trigger levels and available actions

## Industry Standards Applied

- **Basel III LCR**: Liquidity Coverage Ratio calculation and minimum requirements
- **Basel III NSFR**: Net Stable Funding Ratio for structural liquidity
- **BCBS 248**: Monitoring tools for intraday liquidity management