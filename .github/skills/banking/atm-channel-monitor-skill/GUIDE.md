# ATM Channel Monitor Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when monitoring ATM network operations including device availability, cash forecasting, transaction success rates, security event detection, and ATM fleet performance optimization.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [atm-channel-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
atm-channel-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@atm-channel-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Monitor real-time ATM status: online, offline, out-of-cash, error states
- Forecast cash demand by ATM using historical patterns and event calendars
- Detect anomalous withdrawal patterns indicating potential fraud or attack
- Identify skimming device indicators from transaction velocity and decline patterns

## Industry Standards Applied

- **PCI PTS**: PIN Transaction Security requirements for ATM terminals
- **EMV Contact/Contactless**: Chip card and NFC payment acceptance standards
- **ISO 8583**: ATM transaction message format standards