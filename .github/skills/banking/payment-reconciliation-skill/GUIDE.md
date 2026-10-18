# Payment Reconciliation Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when reconciling payment transactions across origination, clearing, and settlement systems for ACH, wire, card, and real-time payment channels, identifying and resolving discrepancies.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [payment-reconciliation-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
payment-reconciliation-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@payment-reconciliation` agent from the Independent Agents catalogue.

## Key Capabilities

- Reconcile ACH batches between origination, Fed/EPN, and posting systems
- Match SWIFT payment messages with core banking debit/credit entries
- Reconcile card settlement files from Visa/Mastercard with acquirer/issuer records
- Identify reconciliation breaks and classify by type: timing, amount, missing

## Industry Standards Applied

- **NACHA Operating Rules**: ACH payment processing and settlement requirements
- **Fedwire Operating Circular 6**: Federal Reserve wire transfer service rules
- **ISO 8583/20022**: Payment message standards for matching and reconciliation