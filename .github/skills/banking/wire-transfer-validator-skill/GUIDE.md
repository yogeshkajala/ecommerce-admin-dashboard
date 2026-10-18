# Wire Transfer Validator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when validating domestic and international wire transfer processing including Fedwire and CHIPS compliance, OFAC screening, travel rule compliance, and wire transfer reconciliation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [wire-transfer-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
wire-transfer-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@wire-transfer-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate wire transfer instructions for completeness and formatting
- Screen all wire parties against OFAC sanctions lists before processing
- Verify Travel Rule compliance: originator and beneficiary information for transfers >=,000
- Monitor Fedwire and CHIPS processing windows and cutoff compliance

## Industry Standards Applied

- **Fedwire Operating Circular 6**: Federal Reserve wire transfer service procedures
- **CHIPS Rules**: Clearing House Interbank Payments System operating rules
- **BSA Travel Rule**: Recordkeeping and information requirements for wire transfers