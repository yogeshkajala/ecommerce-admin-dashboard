# Best Execution Analyzer Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when analyzing trade execution quality for best execution compliance including venue analysis, execution benchmark comparison, transaction cost analysis, and best execution policy monitoring for wealth management trading desks.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [best-execution-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
best-execution-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@best-execution-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Compare execution prices against benchmarks: VWAP, arrival price, closing price
- Calculate implementation shortfall decomposition: timing, market impact, opportunity
- Analyze execution venue quality: fill rates, price improvement, execution speed
- Monitor broker performance across execution quality dimensions

## Industry Standards Applied

- **SEC Rule 606**: Order routing disclosure requirements for broker-dealers
- **MiFID II RTS 28**: Annual best execution venue reporting requirements
- **FINRA Rule 5310**: Best execution and interpositioning requirements