# AML Transaction Monitor Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when monitoring financial transactions for suspicious activity patterns, detecting potential money laundering schemes (structuring, layering, integration), generating Suspicious Activity Reports (SARs), and ensuring BSA/AML compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aml-transaction-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aml-transaction-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aml-transaction-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze transaction patterns for structuring (breaking transactions below CTR thresholds)
- Detect rapid movement of funds indicative of layering schemes
- Identify round-trip transactions and circular fund flows
- Monitor peer-group deviations in transaction behavior

## Industry Standards Applied

- **BSA/AML**: Suspicious Activity Report filing requirements and thresholds
- **FinCEN Guidelines**: SAR filing procedures, CTR requirements, and beneficial ownership
- **FATF 40 Recommendations**: International standards for combating money laundering and terrorist financing