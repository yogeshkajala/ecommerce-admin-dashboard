# SWIFT Message Validator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when validating SWIFT financial messages (MT/MX), ensuring compliance with SWIFT standards, verifying message formatting, and testing end-to-end payment message flows for correspondent banking operations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [swift-message-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
swift-message-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@swift-message-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate SWIFT MT message structure against SWIFT Standards Release Guide
- Parse and validate ISO 20022 MX messages including pacs, camt, and pain schemas
- Test end-to-end payment message flows: MT103, MT202, MT199, MT299
- Verify sanctions screening integration points in message processing chain

## Industry Standards Applied

- **SWIFT Standards Release Guide**: MT message format specifications and validation rules
- **ISO 20022**: MX message schemas for payments, cash management, and securities
- **SWIFT CSP**: Customer Security Programme mandatory and advisory controls