# Deposit Reconciliation Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when reconciling deposit account balances across core banking, general ledger, and subsidiary systems, validating interest posting accuracy, and ensuring regulatory reserve and reporting compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [deposit-reconciliation-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
deposit-reconciliation-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@deposit-reconciliation` agent from the Independent Agents catalogue.

## Key Capabilities

- Reconcile deposit balances between core banking, GL, and data warehouse
- Validate daily interest accrual calculations against posted amounts
- Verify FDIC insurance coverage calculations for per-depositor aggregation
- Identify and classify reconciliation breaks by type and root cause

## Industry Standards Applied

- **FDIC Part 370**: Recordkeeping for timely deposit insurance determination
- **Regulation D**: Reserve requirements for depository institutions
- **ASC 405**: Accounting for deposit liabilities and accrued interest