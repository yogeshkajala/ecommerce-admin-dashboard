# Payment Gateway Validator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when validating payment gateway configurations, testing payment processing flows (authorization, capture, settlement, chargeback), ensuring PCI DSS compliance, and verifying payment scheme rule adherence for Visa, Mastercard, and other networks.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [payment-gateway-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
payment-gateway-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@payment-gateway-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate payment gateway API integration for authorization, capture, void, and refund
- Test 3-D Secure 2.0 authentication flows including frictionless and challenge paths
- Verify cardholder data encryption in transit and at rest per PCI DSS requirements
- Check tokenization implementation for recurring payment and card-on-file scenarios

## Industry Standards Applied

- **PCI DSS v4.0**: Payment card industry data security standard controls
- **EMV 3DS 2.0**: Strong customer authentication for card-not-present transactions
- **ISO 8583**: Financial transaction card message interchange specification