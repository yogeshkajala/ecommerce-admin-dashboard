# Fund Performance Benchmarker Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when benchmarking investment fund performance including return attribution, peer comparison, risk-adjusted metrics, and GIPS-compliant performance reporting for managed portfolios and fund products.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [fund-performance-benchmarker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
fund-performance-benchmarker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@fund-performance-benchmarker` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate time-weighted and money-weighted returns per GIPS standards
- Perform Brinson-Fachler attribution: allocation, selection, interaction effects
- Benchmark against market indices with tracking error and information ratio analysis
- Compare performance against peer group universes with percentile ranking

## Industry Standards Applied

- **CFA Institute GIPS**: Global Investment Performance Standards for return calculation and reporting
- **SEC Marketing Rule (206(4)-1)**: Performance advertising requirements for investment advisors
- **FINRA Rule 2210**: Communications with the public including performance presentation