# Merchant Onboarding Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when managing merchant onboarding for card acquiring including KYB (Know Your Business) verification, risk assessment, underwriting, pricing, and ongoing merchant monitoring for compliance and fraud risk.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [merchant-onboarding-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
merchant-onboarding-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@merchant-onboarding` agent from the Independent Agents catalogue.

## Key Capabilities

- Perform KYB verification: business registration, beneficial owners, website review
- Classify merchant risk based on MCC, processing volume, chargeback history, and geography
- Underwrite merchant accounts with appropriate reserve and limit structures
- Set pricing structures: interchange-plus, tiered, or flat-rate models

## Industry Standards Applied

- **Visa Acquirer Risk Program**: Visa merchant monitoring and risk management requirements
- **Mastercard Merchant Monitoring**: Mastercard acquirer obligations for merchant oversight
- **BSA/AML**: Anti-money laundering requirements for merchant acquiring