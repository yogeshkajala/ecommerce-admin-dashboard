# Investment Policy Enforcer Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when monitoring and enforcing investment policy statement (IPS) compliance including asset allocation limits, security restrictions, concentration limits, and liquidity constraints for managed portfolios.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [investment-policy-enforcer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
investment-policy-enforcer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@investment-policy-enforcer` agent from the Independent Agents catalogue.

## Key Capabilities

- Monitor real-time and end-of-day compliance against IPS constraints
- Perform pre-trade compliance checking before order submission
- Check asset allocation bands, sector limits, and issuer concentration
- Enforce restricted security lists: ESG screens, client restrictions, regulatory

## Industry Standards Applied

- **CFA Institute IPS Standards**: Investment Policy Statement content and enforcement guidelines
- **SEC Rule 38a-1**: Compliance policies and procedures for investment companies
- **ERISA 404(a)**: Fiduciary compliance with investment policy for retirement plans