# Market Risk Monitor Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when monitoring market risk exposures for wealth management portfolios including equity market sensitivity, interest rate risk, credit spread exposure, currency risk, and tail risk assessment.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [market-risk-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
market-risk-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@market-risk-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate equity beta and sector factor exposures for portfolio risk assessment
- Measure interest rate sensitivity through DV01 and key rate duration analysis
- Assess credit spread risk using OAS-based spread duration
- Evaluate currency exposure from international holdings and hedging positions

## Industry Standards Applied

- **CFA Risk Management**: Portfolio risk measurement and monitoring best practices
- **Basel III Market Risk**: VaR and Expected Shortfall calculation methodologies
- **GIPS Risk Measures**: Risk disclosure requirements for performance reporting