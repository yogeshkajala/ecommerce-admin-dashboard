# Commercial Lending Analyzer Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when analyzing commercial lending portfolios including credit analysis, financial spreading, covenant monitoring, risk rating assignment, and concentration risk management for C&I and CRE exposures.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [commercial-lending-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
commercial-lending-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@commercial-lending-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Spread financial statements: income statement, balance sheet, cash flow
- Calculate key financial ratios: leverage, coverage, liquidity, profitability
- Monitor covenant compliance with automated threshold checking and alerts
- Assign risk ratings using dual rating system (borrower and facility)

## Industry Standards Applied

- **OCC Comptroller Handbook - CRE**: Commercial real estate lending concentration guidance
- **Interagency CRE Guidance (2006)**: Concentration risk management for CRE lending
- **Basel III**: Credit risk capital calculation for commercial exposures