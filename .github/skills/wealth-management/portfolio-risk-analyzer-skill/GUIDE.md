# Portfolio Risk Analyzer Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when analyzing investment portfolio risk metrics including Value-at-Risk (VaR), Conditional VaR, Sharpe ratio, drawdown analysis, and stress testing across asset classes for high-net-worth and institutional portfolios.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [portfolio-risk-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
portfolio-risk-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@portfolio-risk-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Calculate parametric, historical, and Monte Carlo VaR at multiple confidence levels
- Compute Conditional VaR (Expected Shortfall) for tail risk assessment
- Perform factor-based risk decomposition: market, sector, style, currency
- Run historical stress tests: 2008 GFC, COVID-19, rate shock, credit crisis

## Industry Standards Applied

- **CFA Institute GIPS**: Global Investment Performance Standards for risk reporting
- **Basel III Market Risk**: VaR and Expected Shortfall calculation methodologies
- **UCITS (EU)**: Risk management and VaR limits for collective investment schemes