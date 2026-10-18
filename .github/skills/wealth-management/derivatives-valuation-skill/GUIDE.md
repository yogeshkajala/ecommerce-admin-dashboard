# Derivatives Valuation Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when valuing derivative instruments in wealth management portfolios including options, structured notes, interest rate swaps, and currency forwards for performance reporting and risk management.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [derivatives-valuation-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
derivatives-valuation-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@derivatives-valuation` agent from the Independent Agents catalogue.

## Key Capabilities

- Price European and American options using Black-Scholes and binomial tree models
- Value structured notes decomposing into bond + embedded option components
- Calculate interest rate swap fair values using yield curve bootstrapping
- Mark currency forwards and options using covered interest rate parity

## Industry Standards Applied

- **ASC 815**: Derivative accounting and hedge accounting requirements
- **ISDA Definitions**: Standard definitions for OTC derivative valuation
- **Black-Scholes-Merton**: Standard option pricing model for European options