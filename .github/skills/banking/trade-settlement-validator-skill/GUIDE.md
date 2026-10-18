# Trade Settlement Validator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when validating securities trade settlement processing including T+1 settlement compliance, DTCC/NSCC interaction, fails management, and reconciliation of trade, position, and cash records across front-to-back systems.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [trade-settlement-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
trade-settlement-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@trade-settlement-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate trade matching and confirmation across counterparties
- Monitor settlement instruction delivery to DTCC/NSCC and custodians
- Track settlement status through lifecycle: matched, affirmed, settled, failed
- Identify and escalate potential settlement fails before settlement date

## Industry Standards Applied

- **SEC Rule 15c6-1**: T+1 standard settlement cycle for securities transactions
- **DTCC/NSCC Rules**: Clearing and settlement procedures for US securities markets
- **ISO 15022/20022**: Securities messaging standards for settlement instructions