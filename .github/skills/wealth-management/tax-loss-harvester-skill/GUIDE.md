# Tax Loss Harvester Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when identifying and executing tax-loss harvesting opportunities across investment portfolios including loss identification, replacement security selection, wash sale avoidance, and year-end tax planning for taxable accounts.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [tax-loss-harvester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
tax-loss-harvester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@tax-loss-harvester` agent from the Independent Agents catalogue.

## Key Capabilities

- Scan portfolios for unrealized losses exceeding minimum threshold per lot
- Identify optimal lots for harvesting considering holding period and loss magnitude
- Select replacement securities maintaining similar factor exposure without wash sale
- Monitor 30-day wash sale lookback and forward windows across household accounts

## Industry Standards Applied

- **IRC Section 1091**: Wash sale disallowance rules for substantially identical securities
- **IRC Section 1001**: Capital gain/loss recognition and computation rules
- **IRC Section 1(h)**: Capital gains tax rates: short-term, long-term, collectibles