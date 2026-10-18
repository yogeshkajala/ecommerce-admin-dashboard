# Collateral Management Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when managing loan collateral including valuation monitoring, lien perfection tracking, collateral coverage ratio calculation, margin call processing, and collateral substitution workflows for secured lending.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [collateral-management-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
collateral-management-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@collateral-management` agent from the Independent Agents catalogue.

## Key Capabilities

- Monitor collateral market values against loan-to-value covenant requirements
- Track UCC-1 filing dates, continuation statements, and amendments
- Calculate collateral coverage ratios including haircuts by asset class
- Process margin calls with notification, cure period, and liquidation workflows

## Industry Standards Applied

- **UCC Article 9**: Secured transaction perfection and priority rules
- **OCC Comptroller Handbook - Loan Portfolio**: Collateral valuation and monitoring guidance
- **Basel III**: Credit risk mitigation through collateral recognition