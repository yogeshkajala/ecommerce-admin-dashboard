# Open Banking API Designer Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when designing Open Banking APIs compliant with PSD2, FDX, and other open finance standards, implementing secure consent management, and enabling third-party provider access to banking data and payment initiation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [open-banking-api-designer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
open-banking-api-designer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@open-banking-api-designer` agent from the Independent Agents catalogue.

## Key Capabilities

- Design Account Information Service Provider (AISP) APIs per Berlin Group or UK OB specs
- Design Payment Initiation Service Provider (PISP) APIs with SCA enforcement
- Implement OAuth 2.0 / FAPI security profiles for API access control
- Build consent management APIs supporting granular permissions and revocation

## Industry Standards Applied

- **PSD2 (EU)**: Payment Services Directive 2 open banking requirements
- **UK Open Banking Standard**: UK API specifications for account and payment access
- **FDX (Financial Data Exchange)**: US standard for financial data sharing APIs