# Custodian Reconciliation Skill

> **Category:** Domain Skills > Industry > Wealth Management

## Overview

Use when reconciling portfolio positions, transactions, and cash balances between investment advisors internal records, custodian statements, and external data aggregation platforms for wealth management operations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [custodian-reconciliation-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
custodian-reconciliation-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@custodian-reconciliation` agent from the Independent Agents catalogue.

## Key Capabilities

- Reconcile positions at security level between advisor platform and custodian
- Match trade confirmations between OMS, execution venues, and custodian records
- Identify and classify reconciliation breaks: position, cash, corporate action, trade
- Process corporate actions reconciliation: dividends, splits, mergers, tenders

## Industry Standards Applied

- **SEC Rule 206(4)-2**: Custody rule requiring independent verification of client assets
- **SOC 1 Type II**: Service organization controls for custody and reconciliation
- **GIPS**: Data accuracy requirements for performance calculation inputs