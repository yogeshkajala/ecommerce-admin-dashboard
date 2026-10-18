# Client Portfolio Rebalancer Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when rebalancing client investment portfolios including drift detection, tax-aware trading, wash sale avoidance, and multi-account household rebalancing across taxable and tax-advantaged accounts.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [client-portfolio-rebalancer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
client-portfolio-rebalancer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@client-portfolio-rebalancer` agent from the Independent Agents catalogue.

## Key Capabilities

- Monitor portfolio drift against target allocation with configurable tolerance bands
- Generate tax-aware trade lists minimizing short-term capital gains
- Avoid wash sale violations across household accounts per IRC Section 1091
- Optimize asset location across taxable, IRA, and Roth account types

## Industry Standards Applied

- **IRC Section 1091**: Wash sale rules preventing loss recognition on repurchased securities
- **Prudent Investor Rule**: Fiduciary obligation for periodic portfolio rebalancing
- **GIPS**: Performance attribution after rebalancing transactions