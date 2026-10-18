# Card Processing Auditor Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when auditing card processing operations including issuing, acquiring, authorization routing, settlement, and interchange compliance for debit and credit card programs.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [card-processing-auditor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
card-processing-auditor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@card-processing-auditor` agent from the Independent Agents catalogue.

## Key Capabilities

- Audit authorization routing logic for optimal interchange qualification
- Validate settlement file accuracy between issuer, acquirer, and network
- Analyze interchange downgrade patterns and recommend qualification improvements
- Review card program parameters against Visa/Mastercard operating regulations

## Industry Standards Applied

- **PCI DSS v4.0**: Card data security controls for issuing and acquiring
- **Durbin Amendment (Reg II)**: Debit card interchange and routing requirements
- **Visa Core Rules**: Visa network operating regulations for issuers and acquirers