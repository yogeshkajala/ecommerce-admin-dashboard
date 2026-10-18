# FX Rate Monitor Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when monitoring foreign exchange rates for banking operations including spot and forward rate validation, FX risk exposure calculation, and compliance with FX Global Code of Conduct.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [fx-rate-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
fx-rate-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@fx-rate-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Monitor real-time spot and forward FX rates from multiple market data sources
- Validate customer FX pricing against benchmark rates and markup policies
- Calculate portfolio FX exposure by currency pair, tenor, and business line
- Monitor FX limit utilization: intraday, end-of-day, settlement, and credit

## Industry Standards Applied

- **FX Global Code of Conduct**: Principles for good practices in FX markets
- **ISDA Definitions (2006/2021)**: FX product definitions and settlement conventions
- **ASC 815**: Hedge accounting requirements for FX derivatives